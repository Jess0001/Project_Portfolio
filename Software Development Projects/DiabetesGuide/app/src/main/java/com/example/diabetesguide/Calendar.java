package com.example.diabetesguide;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CalendarView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Calendar extends AppCompatActivity {

    private FirebaseDatabase database = FirebaseDatabase.getInstance();
    //add reminders to path
    private DatabaseReference diabetesGuideRef = database.getReference("RemindersInfo");
    private List<String> listOfReminders;
    private ArrayAdapter<String> remindersAdapter;
    private Date selectedDate;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calendar);

        TextView remindersList = findViewById(R.id.events_txt);
        Button createNewReminder_btn = findViewById(R.id.createNewEvent_btn);
        ListView reminders_List = findViewById(R.id.reminders_list);
        listOfReminders = new ArrayList<>();

        // get the reference of CalendarView
        CalendarView eventCalender = findViewById(R.id.testCalendar);
        eventCalender.setOnDateChangeListener(new CalendarView.OnDateChangeListener() {
            @Override
            public void onSelectedDayChange(CalendarView calendarView, int year, int month, int day) {
                String  dateDay = String.valueOf(day);
                String  dateYear = String.valueOf(year);
                String  dateMonth = String.valueOf(month);
                String date = "Selected Date: " + dateDay+"/"+dateMonth+"/"+dateYear;
                SimpleDateFormat format = new SimpleDateFormat("dd/mm/yyyy");
                try {
                    selectedDate = format.parse(date);
                } catch (ParseException e) {
                    e.printStackTrace();
                }
                Toast.makeText(Calendar.this, date, Toast.LENGTH_SHORT).show();
            }
        });

        diabetesGuideRef.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                for(DataSnapshot pulledReminders : snapshot.getChildren()){
                    RemindersInfo reminders = pulledReminders.getValue(RemindersInfo.class);
                }

                remindersAdapter = new ArrayAdapter<>(Calendar.this, android.R.layout.simple_list_item_1, listOfReminders);
                reminders_List.setAdapter(remindersAdapter);
                diabetesGuideRef.child("Reminders").orderByChild("reminderDate").startAt(selectedDate.toString()).endAt(selectedDate.toString());
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {
                //set to default
                Toast.makeText(Calendar.this, "No events available on " + selectedDate + ".", Toast.LENGTH_SHORT).show();
            }
        });

        createNewReminder_btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // create intent object with context and class name of other activity
                Intent intent = new Intent(getApplicationContext(), Reminders.class);
                // call startActivity method and pass intent
                startActivity(intent);

            }
        });
    }
}
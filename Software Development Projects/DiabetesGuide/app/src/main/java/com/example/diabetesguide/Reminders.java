package com.example.diabetesguide;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;

public class Reminders extends AppCompatActivity {
    RadioButton radioButtonMeds, radioButtonTestLevels, radioButtonEndFast;
    EditText editTextDateLevels, editTextDateMeds, editTextDateFast;
    Button buttonReminderNew, buttonBack;

    RemindersInfo remindersInfo;

    ArrayList<String> reminderInfo = new ArrayList<>();

    FirebaseDatabase firebasedatabase;

    DatabaseReference databaseReference;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_reminders);

        buttonReminderNew = (Button) findViewById(R.id.button);

        editTextDateFast = (EditText) findViewById(R.id.editTextDateFasting);

        editTextDateLevels = (EditText) findViewById(R.id.editTextDateLevels);

        editTextDateMeds = (EditText) findViewById(R.id.editTextDateMeds);

        radioButtonMeds = (RadioButton) findViewById(R.id.radioButtonMeds);

        radioButtonEndFast = (RadioButton) findViewById(R.id.radioButtonEndFast);

        radioButtonTestLevels = (RadioButton) findViewById(R.id.radioButtonTestLevels);

        buttonBack = (Button) findViewById(R.id.buttonBack);

        firebasedatabase = FirebaseDatabase.getInstance();

        databaseReference = firebasedatabase.getReference("RemindersInfo");

        remindersInfo = new RemindersInfo();

        buttonReminderNew.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {


                reminderInfo.add(editTextDateFast.toString());
                reminderInfo.add(editTextDateMeds.toString());
                reminderInfo.add(editTextDateLevels.toString());
                reminderInfo.add(radioButtonEndFast.toString());
                reminderInfo.add(radioButtonEndFast.toString());
                reminderInfo.add(radioButtonMeds.toString());
                reminderInfo.add(radioButtonTestLevels.toString());

                DatabaseReference rootRef = FirebaseDatabase.getInstance().getReference();
                for(String reminderInfo : reminderInfo) {
                    rootRef.child("reminderInfo").child(reminderInfo).setValue(true);
                }

                AddDatatoFirebase();



            }

        });
    }

    private void AddDatatoFirebase() {

        databaseReference.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {

                databaseReference.setValue(reminderInfo);


                Toast.makeText(Reminders.this, "data added", Toast.LENGTH_SHORT).show();
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

                Toast.makeText(Reminders.this, "Fail to add data " + error, Toast.LENGTH_SHORT).show();
            }
        });
    }
}

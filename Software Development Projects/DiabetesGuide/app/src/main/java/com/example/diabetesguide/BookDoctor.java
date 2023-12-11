package com.example.diabetesguide;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;

public class BookDoctor extends AppCompatActivity {

    EditText editTextDoctor, editTextDoctorNotes;
    Button buttonRequestDate, btnBack;
    TextView textViewNotes, BookAppointment;
    ImageView DoctorPhoto;

    ArrayList<String> docInfo = new ArrayList<>();


    FirebaseDatabase firebasedatabase;

    DatabaseReference databasereference;

    DoctorInfo doctorInfo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_book_doctor);

        buttonRequestDate = (Button) findViewById(R.id.buttonRequestDate);

        editTextDoctor = (EditText) findViewById(R.id.editTextDoctor);

        editTextDoctorNotes = (EditText) findViewById(R.id.editTextDoctorNotes);

        textViewNotes = (TextView) findViewById(R.id.textViewNotes);

        BookAppointment = (TextView) findViewById(R.id.BookAppointment);

        DoctorPhoto = (ImageView) findViewById(R.id.DoctorPhoto);

        btnBack = (Button) findViewById(R.id.btnBack);

        firebasedatabase = FirebaseDatabase.getInstance();

        databasereference = firebasedatabase.getReference("DoctorInfo");

        doctorInfo = new DoctorInfo();


        buttonRequestDate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                docInfo.add(editTextDoctor.toString());
                docInfo.add(editTextDoctorNotes.toString());
                docInfo.add(DoctorPhoto.toString());

                DatabaseReference rootRef = FirebaseDatabase.getInstance().getReference();
                for(String docInfo : docInfo) {
                   rootRef.child("docInfo").child(docInfo).setValue(true);
                }

                addDatatoFirebase();
            }


        });


    }

    private void addDatatoFirebase(){

        databasereference.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                // inside the method of on Data change we are setting
                // our object class to our database reference.
                // data base reference will sends data to firebase.
                databasereference.setValue(docInfo.toString());

                // after adding this data we are showing toast message.
                Toast.makeText(BookDoctor.this, "data added", Toast.LENGTH_SHORT).show();
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {
                // if the data is not added or it is cancelled then
                // we are displaying a failure toast message.
                Toast.makeText(BookDoctor.this, "Fail to add data " + error, Toast.LENGTH_SHORT).show();
            }
        });

    }
}
package com.example.diabetesguide;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Create_Logs extends AppCompatActivity {

    String timeRecorded;
    String bloodPressure;
    String medication;
    String foodTypes;
    String activity;

    double bloodSugar;

    EditText timeEdt;
    EditText bloodSugarEdt;
    EditText bloodPressureEdt;
    EditText medicationEdt;
    EditText foodTypesEdt;
    EditText activityEdt;

    Button createLogBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_create_logs);

        timeEdt = (EditText) findViewById(R.id.edtTime);
        bloodSugarEdt = (EditText) findViewById(R.id.edtBloodSugar);
        bloodPressureEdt = (EditText) findViewById(R.id.edtBloodPressure);
        medicationEdt = (EditText) findViewById(R.id.edtMedication);
        foodTypesEdt = (EditText) findViewById(R.id.edtFood);
        activityEdt = (EditText) findViewById(R.id.edtActivity);



        createLogBtn = (Button) findViewById(R.id.btnCreateLog);
        createLogBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                timeRecorded = timeEdt.getText().toString();
                bloodSugar = Integer.valueOf(bloodSugarEdt.getText().toString());
                bloodPressure = bloodPressureEdt.getText().toString();
                medication = medicationEdt.getText().toString();
                foodTypes = foodTypesEdt.getText().toString();
                activity = activityEdt.getText().toString();


                Intent myIntent = new Intent(Create_Logs.this, Stats.class);
                myIntent.putExtra("Time", timeRecorded);

                myIntent = new Intent(Create_Logs.this, Reccomendations.class);
                myIntent.putExtra("Time", timeRecorded);
                //myIntent.putExtra("bloodSugar", bloodSugar);
                
                myIntent.putExtra("bloodSugar", bloodSugar);
                startActivity(myIntent);

            }
        });

    }
}
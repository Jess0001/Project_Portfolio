package com.example.diabetesguide;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;

import androidx.appcompat.app.AppCompatActivity;

public class Home extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.home);
        // initiate view's
        ImageButton imageButtonAccount = (ImageButton)findViewById(R.id.imageButtonAccount);
        ImageButton imageButtonStats = (ImageButton)findViewById(R.id.imageButtonStats);
        ImageButton imageButtonAppointment = (ImageButton)findViewById(R.id.imageButtonAppointment);
        ImageButton imageButtonCalender = (ImageButton)findViewById(R.id.imageButtonCalander);
        ImageButton imageButtonReminder = (ImageButton)findViewById(R.id.imageButtonReminder);
        ImageButton imageButtonTips = (ImageButton)findViewById(R.id.imageButtonTips);
        ImageButton imageButtonMed = (ImageButton)findViewById(R.id.imageButtonMed);
        Button btnLog = (Button)findViewById(R.id.btnLog);

        // perform click event on button's
        imageButtonAccount.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i  = new Intent(Home.this, Account.class);
                startActivity(i);
            }
        });
        imageButtonStats.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i  = new Intent(Home.this, Stats.class);
                startActivity(i);
            }
        });
        imageButtonAppointment.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i  = new Intent(Home.this, BookDoctor.class);
                //startActivity(i);
            }
        });
        imageButtonCalender.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i  = new Intent(Home.this, Calendar.class);
                startActivity(i);
            }
        });
        imageButtonMed.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i  = new Intent(Home.this, Account.class);
                startActivity(i);
            }
        });
        imageButtonReminder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i  = new Intent(Home.this, Reminders.class);
                startActivity(i);
            }
        });
        imageButtonTips.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i  = new Intent(Home.this, Tips_Tricks.class);
                startActivity(i);
            }
        });
        btnLog.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i  = new Intent(Home.this, Create_Logs.class);
                startActivity(i);
            }
        });
    }

}

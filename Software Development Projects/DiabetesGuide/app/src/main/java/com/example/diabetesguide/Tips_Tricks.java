package com.example.diabetesguide;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Tips_Tricks extends AppCompatActivity {

    String urlHealth = "https://www.diabetessa.org.za/healthy-eating/";
    String urlTesting = "https://www.diabetessa.org.za/testing/";
    String urlExercise = "https://www.diabetessa.org.za/physical-activity/";
    String urlMedication = "https://www.diabetessa.org.za/category/atoz-2022-your-journey/treatment-atoz-2022/medication/";

    Button View1;
    Button View2;
    Button View3;
    Button View4;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tips_tricks);


        // open testing link
            View1 = findViewById(R.id.View1);
            View1.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent i = new Intent(Intent.ACTION_VIEW);
                    i.setData(Uri.parse(urlTesting));
                    startActivity(i);
                }
            });


        // open health link
        View2 = findViewById(R.id.View2);
        View2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(Intent.ACTION_VIEW);
                i.setData(Uri.parse(urlHealth));
                startActivity(i);
            }
        });

        // open exercise
        View3 = findViewById(R.id.View3);
        View3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(Intent.ACTION_VIEW);
                i.setData(Uri.parse(urlExercise));
                startActivity(i);
            }
        });

        // open Medication
        View4 = findViewById(R.id.View4);
        View4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(Intent.ACTION_VIEW);
                i.setData(Uri.parse(urlMedication));
                startActivity(i);
            }
        });




    }
}
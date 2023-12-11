package com.example.diabetesguide;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

public class Reccomendations extends AppCompatActivity {

    String LevelsDisplay;
    Double CurrentLevel;
    //double GoalLevel;

    TextView currentLevel;
    TextView GoalLevel;
    TextView levelDisplay;
    TextView RecommendationTxt;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_reccomendations);


        double getBloodSugar = getIntent().getIntExtra("BloodSugar",0);
        Intent receiveIntent = this.getIntent();

        double dBloodSugar = getBloodSugar;
        currentLevel = findViewById(R.id.currentLevel);

        String strBloodSugar= Double.toString(dBloodSugar);
        currentLevel.setText(strBloodSugar);

        GoalLevel = findViewById(R.id.goallevel);
        GoalLevel.setText("125");


        if( dBloodSugar > 125)
        {
            levelDisplay = findViewById(R.id.LevelsDisplay);
            levelDisplay.setText("HIGH");

            RecommendationTxt = findViewById(R.id.recommendation);
            RecommendationTxt.setText("A quick way to reduce blood sugar is to take fast acting insulin, it is reccomemded that you do some excercise and try eat consistent healthy meals to reduce levels. \"visit https://www.diabetessa.org.za/ for more information\"");



        }
        if( dBloodSugar < 70)
        {
            levelDisplay = findViewById(R.id.LevelsDisplay);
            levelDisplay.setText("LOW");
            RecommendationTxt = findViewById(R.id.recommendation);
            RecommendationTxt.setText("Consume a small amount of sugary foods, wait about 10 minutes and re-do the test to ensure blood sugar is at optimal level." +
                    "visit https://www.diabetessa.org.za/ for more information");
        }
        else
        {
            levelDisplay = findViewById(R.id.LevelsDisplay);
            levelDisplay.setText("AVERAGE");
        }







    }
}
package com.example.diabetesguide;

import android.content.Intent;
import android.os.Bundle;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Intent SplashIntent = new Intent(getApplicationContext(),Splash_Screen.class);
        startActivity(SplashIntent);
        finish();
    }

}
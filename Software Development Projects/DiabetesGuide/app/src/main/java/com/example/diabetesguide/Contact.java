package com.example.diabetesguide;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Contact extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contact);
        Button selectContactForm_btn = findViewById(R.id.selectContactForm_btn);

        selectContactForm_btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // create intent object with context and class name of other activity
                Intent intent = new Intent(getApplicationContext(), ContactForm.class);
                // call startActivity method and pass intent
                startActivity(intent);
            }
        });
    }
}
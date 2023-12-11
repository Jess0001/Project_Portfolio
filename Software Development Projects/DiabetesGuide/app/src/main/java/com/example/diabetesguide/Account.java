package com.example.diabetesguide;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class Account extends AppCompatActivity {
    String[] Insulin_result = {"Yes", "No"};
    String[] Fitness_result = {"Beginner", "Moderate", "Right Intensity", "High Intensity"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.account);
//initiate view's
        Button btnSave = (Button)findViewById(R.id.btnSave);
        Button btnEdit = (Button)findViewById(R.id.btnEdit);
        Button btnAdd = (Button)findViewById(R.id.btnAdd);

        //perform click event on button's
        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i  = new Intent(Account.this, User_Profile.class);
                startActivity(i);
            }
        });
        btnEdit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

            }
        });
        btnSave.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

            }
        });

        // Take the instance of Spinner and
        // apply OnItemSelectedListener on it which
        // tells which item of spinner is clicked
        /*Spinner spinner_Insulin = findViewById(R.id.spinner_Insulin);
        Spinner spinner_Fitness = findViewById(R.id.spinner_Fitness);


        //Performing action onItemSelected and onNothing selected
        // Getting the instance of Spinner and applying OnItemSelectedListener on it
        spinner_Insulin.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                ArrayAdapter aa = new ArrayAdapter(Account.this, android.R.layout.simple_spinner_item, Insulin_result);
                aa.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                //Setting the ArrayAdapter data on the Spinner
                spinner_Insulin.setAdapter(aa);

                Toast.makeText(getApplicationContext(), Insulin_result[position], Toast.LENGTH_LONG).show();
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                // TODO Auto-generated method stub

            }
        });

        spinner_Fitness.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                ArrayAdapter ab = new ArrayAdapter(Account.this, android.R.layout.simple_spinner_item, Fitness_result);
                ab.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                spinner_Fitness.setAdapter(ab);
                Toast.makeText(getApplicationContext(), Fitness_result[position], Toast.LENGTH_LONG).show();
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                // TODO Auto-generated method stub

            }
        });
*/
    }
}

package com.example.diabetesguide;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Button;

public class User_Profile extends AppCompatActivity {

    RadioGroup radioGroup;
    RadioButton radioButton;
    int radioID;
    EditText HealthIssueEdt;
    EditText WeightEdt;
    EditText HeightEdt;
    String HealthIssue;
    int weight;
    int height;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_user_profile);

        radioGroup = findViewById(R.id.radioGroup);

        HealthIssueEdt = (EditText) findViewById(R.id.edtHealthIssue);

        WeightEdt = (EditText) findViewById(R.id.edtWeight);

        HeightEdt = (EditText) findViewById(R.id.edtHeight);


        Button Save = findViewById(R.id.btnSave);
        Save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                HealthIssue = HealthIssueEdt.getText().toString();

                weight = Integer.valueOf(WeightEdt.getText().toString());

                height = Integer.valueOf(HeightEdt.getText().toString());

                int radioID = radioGroup.getCheckedRadioButtonId();
                radioButton = findViewById(radioID);





            }
        });
    }


    public void SaveUserDetails(View v)
    {

        int radioID = radioGroup.getCheckedRadioButtonId();
        radioButton.findViewById(radioID);


    }




}
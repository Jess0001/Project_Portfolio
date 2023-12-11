package com.example.diabetesguide;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Message;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import android.os.Bundle;
import android.widget.Toast;

public class ContactForm extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contact_form);
        TextView name = findViewById(R.id.idEdtName);
        TextView phoneNumber = findViewById(R.id.idEdtPhoneNumber);
        TextView emailAddress = findViewById(R.id.idEdtEmail);
        TextView message = findViewById(R.id.idEdtNote);
        Button submit_btn = findViewById(R.id.idBtnSubmit);

        submit_btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String emailsend = "national@diabetessa.org.za";
                String emailsubject = "Query from Diabetes Guide com.example.diabetesguide.User";
                String emailbody = message.getText() +
                        "\nContact Details" +
                        "\nName: " + name.getText() +
                        "\nPhone Number: " + phoneNumber.getText() +
                        "\nEmail Address: " + emailAddress.getText();

                // define Intent object with action attribute as ACTION_SEND
                Intent intent = new Intent(Intent.ACTION_SEND);

                // add three fields to intent using putExtra function
                intent.putExtra(Intent.EXTRA_EMAIL, new String[]{emailsend});
                intent.putExtra(Intent.EXTRA_SUBJECT, emailsubject);
                intent.putExtra(Intent.EXTRA_TEXT, emailbody);

                // set type of intent
                intent.setType("message/rfc822");

                // startActivity with intent with chooser as Email client using createChooser function
                startActivity(Intent.createChooser(intent, "Choose an Email client :"));
                Toast.makeText(ContactForm.this, "Query sent!", Toast.LENGTH_SHORT).show();
            }
        });
    }
}
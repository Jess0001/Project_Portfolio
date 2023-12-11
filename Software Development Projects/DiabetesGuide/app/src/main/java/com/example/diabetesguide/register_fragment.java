package com.example.diabetesguide;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ProgressBar;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.android.material.textfield.TextInputLayout;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;

public class register_fragment extends Fragment implements View.OnClickListener {

    private TextInputLayout email;
    private TextInputLayout Name;
    private TextInputLayout password;
    private Button register;
    private ProgressBar progressBar;
    private FirebaseAuth sAuth;

    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View v = inflater.inflate(R.layout.activity_register_fragment, container, false);
        sAuth = FirebaseAuth.getInstance();

        email = v.findViewById(R.id.register_textBoxEmail);
        Name=v.findViewById(R.id.register_textBoxName);
        password = v.findViewById(R.id.register_textBoxName);
        register = v.findViewById(R.id.register_button);
        progressBar = v.findViewById(R.id.fragment_register_loader);

        return v;

        //register.setOnClickListener(this);
    }
    @Override
    public void onClick(View view) {
        switch (view.getId()){
            case R.id.register_button:
                validateUser();

        }

    }
    public void validateUser() {
        // Take the value of two edit texts in Strings
        String name,  tmp_email, tmp_password;
        name = Name.getEditText().toString();
        tmp_email = email.getEditText().toString();
        tmp_password = password.getEditText().toString();


        // Validations for input email and password
        if (TextUtils.isEmpty(name)) {
            Toast.makeText(getContext(),
                            "Please enter First Name!!",
                            Toast.LENGTH_LONG)
                    .show();
            return;
        }


        if (TextUtils.isEmpty(tmp_email)) {
            Toast.makeText(getContext(),
                            "Please enter email!!",
                            Toast.LENGTH_LONG)
                    .show();
            return;
        }
        if (TextUtils.isEmpty(tmp_password)) {
            Toast.makeText(getContext(),
                            "Please enter password!!",
                            Toast.LENGTH_LONG)
                    .show();
            return;
        }

        // create new user or register new user
        sAuth
                .createUserWithEmailAndPassword(tmp_email, tmp_password)
                .addOnCompleteListener(new OnCompleteListener<AuthResult>() {

                    @Override
                    public void onComplete(@NonNull Task<AuthResult> task) {
                        if (task.isSuccessful()) {
                            Toast.makeText(getContext(),
                                            "Registration successful!",
                                            Toast.LENGTH_LONG)
                                    .show();

                            // hide the progress bar
                            progressBar.setVisibility(View.GONE);

                            // if the user created intent to login activity
                            Intent Intent = new Intent(getContext(),login_fragment.class);
                            startActivity(Intent);

                        } else {

                            // Registration failed
                            Toast.makeText(
                                            getContext(),
                                            "Registration failed!!"
                                                    + " Please try again later",
                                            Toast.LENGTH_LONG)
                                    .show();

                            // hide the progress bar
                            progressBar.setVisibility(View.GONE);
                        }
                    }
                });
        }
}

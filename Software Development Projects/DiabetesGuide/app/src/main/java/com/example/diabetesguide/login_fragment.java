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

public class login_fragment extends Fragment implements View.OnClickListener{
    private TextInputLayout email;
    private TextInputLayout password;
    private Button login;
    private ProgressBar progressBar;
    private FirebaseAuth sAuth;


    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View v = inflater.inflate(R.layout.activity_login_fragment,container,false);
        sAuth = FirebaseAuth.getInstance();

        email = v.findViewById(R.id.login_textBoxEmail);
        password = v.findViewById(R.id.login_textBoxPassword);
        progressBar = v.findViewById(R.id.fragment_login_progress_bar);
        login = v.findViewById(R.id.login_button);
        return v;
    }
    @Override
    public void onClick(View view) {
        switch (view.getId()){
            case R.id.login_button:
                loginUser();
                break;
        }
    }

    private void loginUser()
    {

        // show the visibility of progress bar to show loading
        progressBar.setVisibility(View.VISIBLE);

        // Take the value of two edit texts in Strings
        String signin_email, user_password;
        signin_email = email.getEditText().toString();
        user_password = password.getEditText().toString();

        // validations for input email and password
        if (TextUtils.isEmpty(signin_email)) {
            Toast.makeText(getContext(),
                            "Please enter email!!",
                            Toast.LENGTH_LONG)
                    .show();
            return;
        }

        if (TextUtils.isEmpty(user_password)) {
            Toast.makeText(getContext(),
                            "Please enter password!!",
                            Toast.LENGTH_LONG)
                    .show();
            return;
        }

        //sign in existing user
        sAuth.signInWithEmailAndPassword(signin_email, user_password)
                .addOnCompleteListener(
                        new OnCompleteListener<AuthResult>() {
                            @Override
                            public void onComplete(
                                    @NonNull Task<AuthResult> task)
                            {
                                if (task.isSuccessful()) {
                                    Toast.makeText(getContext(),
                                                    "Login successful!!",
                                                    Toast.LENGTH_LONG)
                                            .show();

                                    // hide the progress bar
                                    progressBar.setVisibility(View.GONE);

                                    // if sign-in is successful
                                    // intent to home activity
                                    //for whoever is doing the home screen please insert the home screen intent
                                    Intent Intent = new Intent(getContext(), com.example.diabetesguide.MainActivity.class);
                                    startActivity(Intent);
                                }

                                else {

                                    // sign-in failed
                                    Toast.makeText(getContext(),
                                                    "Login failed!!",
                                                    Toast.LENGTH_LONG)
                                            .show();

                                    // hide the progress bar
                                    progressBar.setVisibility(View.GONE);
                                }
                            }
                        });
    }
}

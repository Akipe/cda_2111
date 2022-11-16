package com.akipe.listviewdemo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class DefinePersonActivity extends AppCompatActivity {

    private Intent currentIntent;
    EditText firstnameEt;
    EditText lastnameEt;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_define_person);

        this.currentIntent = getIntent();

        this.firstnameEt = findViewById(R.id.firstname_et);
        this.lastnameEt = findViewById(R.id.lastname_et);

        this.firstnameEt.setHint(this.currentIntent.getStringExtra("firstname"));
        this.lastnameEt.setHint(this.currentIntent.getStringExtra("lastname"));

        Button definePersonBtn = findViewById(R.id.define_person_btn);
        definePersonBtn.setOnClickListener(this::DefinePerson);
    }

    private void DefinePerson(View view)
    {
        this.currentIntent.putExtra("firstname", firstnameEt.getText().toString());
        this.currentIntent.putExtra("lastname", lastnameEt.getText().toString());

        setResult(RESULT_OK, this.currentIntent);
        finish();
    }
}
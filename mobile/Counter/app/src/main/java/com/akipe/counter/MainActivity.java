package com.akipe.counter;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    private Integer number;
    private EditText numberBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        this.number = 10;
        this.numberBtn = findViewById(R.id.numberField);

        this.numberBtn.setText(number.toString());
    }

    public void incrementNumber(View v)
    {
        this.number++;
        this.numberBtn.setText(number);
    }
}
package com.akipe.counter;


import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    private Integer number;
    private EditText numberBtn;
    private Button incrementBtn;
    private Button decrementBtn;
    private Button exitBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        this.number = 10;
        this.numberBtn = findViewById(R.id.numberField);

        this.numberBtn.setText(this.number.toString());

        decrementBtn = findViewById(R.id.decrement_number_btn);
        incrementBtn = findViewById(R.id.increment_number_btn);
        exitBtn = findViewById(R.id.exit_btn);

        decrementBtn.setOnClickListener(
            this::manageNumber
        );
        incrementBtn.setOnClickListener(
            this::manageNumber
        );
        exitBtn.setOnClickListener(
            this::exit
        );
    }

    // Le listener doit avoir cette signature
    public void manageNumber(View view)
    {
        if (view.getId() == R.id.increment_number_btn) {
            this.number++;
        } else {
            this.number--;
        }

        this.numberBtn.setText(this.number.toString());
    }

    public void exit(View view)
    {
        this.finishAndRemoveTask();
        System.exit(0);
    }
}
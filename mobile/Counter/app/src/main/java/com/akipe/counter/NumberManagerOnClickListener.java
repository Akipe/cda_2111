package com.akipe.counter;

import android.view.View;
import android.widget.EditText;

public class NumberManagerOnClickListener implements View.OnClickListener {
    private EditText _numberInput;
    private int _number;

    public NumberManagerOnClickListener(EditText numberInput)
    {
        this._numberInput = numberInput;
    }

    @Override
    public void onClick(View view) {
        if (view.getId() == R.id.increment_number_btn) {
            this._number++;
        } else {
            this._number--;
        }

        this._numberInput.setText(String.format("%d", this._number));
    }
}

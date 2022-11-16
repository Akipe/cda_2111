package com.akipe.listviewdemo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    private TextView firstnameTw;
    private TextView lastnameTw;
    private ListView listPersonsLv;
    private ArrayList<String> listPersons = new ArrayList<String>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        listPersons.add("toto");
        listPersons.add("tata");
        listPersons.add("titi");
        listPersons.add("tutu");

        ArrayAdapter arrayDP = new ArrayAdapter(
                this,
                android.R.layout.simple_list_item_1,
                this.listPersons
        );

        this.firstnameTw = findViewById(R.id.person_firstname);
        this.lastnameTw = findViewById(R.id.person_lastname);
        this.listPersonsLv = findViewById(R.id.list_persons);

        this.listPersonsLv.setAdapter(arrayDP);
        /* Gérer les activités internes ou précises */
        // this: packageContexte, là où on est,
        // com.akipe.listviewdemo.MainActivity.class: classe java qui correspond à l'activité
        //Intent intent = new Intent(this, com.akipe.listviewdemo.MainActivity.class);

        // on démarre l'activité
        //startActivity(intent);

        /* Gérer les activités standart Android ou de d'autres appli */
        //Intent generalIntent = new Intent(Intent.ACTION_DIAL, Uri.parse("tel://0101010101"));
        //startActivity(generalIntent);

        Button definePersonBtn = findViewById(R.id.add_person_btn);
        definePersonBtn.setOnClickListener(
                this::AskDefinePersonActivity
        );
    }

    private void AskDefinePersonActivity(View view)
    {
        Intent definePersonIntent = new Intent(this, com.akipe.listviewdemo.DefinePersonActivity.class);

        definePersonIntent.putExtra("firstname", this.firstnameTw.getText().toString());
        definePersonIntent.putExtra("lastname", this.lastnameTw.getText().toString());

        startActivityForResult(definePersonIntent, 1);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {

        super.onActivityResult(requestCode, resultCode, data);

        this.firstnameTw.setText(data.getStringExtra("firstname"));
        this.lastnameTw.setText(data.getStringExtra("lastname"));
    }
}
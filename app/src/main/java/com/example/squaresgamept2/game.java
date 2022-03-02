package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

public class game extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.gamepage);

        Button pause = (Button) findViewById(R.id.pause);
        pause.setOnClickListener(view -> {
            Intent intent = new Intent(view.getContext(), pause.class);
            startActivity(intent);
        });

        Button replay = (Button) findViewById(R.id.endGame);
        replay.setOnClickListener(view -> {
            Intent intent = new Intent(view.getContext(), endGame.class);
            startActivity(intent);
        });


    }
}
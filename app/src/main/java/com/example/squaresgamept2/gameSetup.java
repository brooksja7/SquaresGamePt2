package com.example.squaresgamept2;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

public class gameSetup extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.gamesetup);

        Button startGame = (Button) findViewById(R.id.startGame);
        startGame.setOnClickListener(view -> {
            Intent intent = new Intent(view.getContext(), game.class);
            startActivity(intent);
        });
    }
}

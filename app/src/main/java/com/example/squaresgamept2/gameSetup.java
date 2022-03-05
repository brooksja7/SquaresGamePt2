package com.example.squaresgamept2;

import android.app.Activity;
import android.content.Intent;
import android.graphics.Typeface;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class gameSetup extends Activity {

    static int numberOfPlayers;
    int xCounter = 0;
    int yCounter = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.gamesetup);

        TextView xView = findViewById(R.id.xNum);
        TextView yView = findViewById(R.id.yNum);

        Button exitBtn = findViewById(R.id.backGamesetup);
        exitBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent mainmenuIntent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(mainmenuIntent);
            }
        });

        Button player2 = findViewById(R.id.player2);
        player2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                numberOfPlayers = 2;
            }
        });

        Button player3 = findViewById(R.id.player3);
        player3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                numberOfPlayers = 3;
            }
        });

        Button player4 = findViewById(R.id.player4);
        player4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                numberOfPlayers = 4;
            }
        });

        Button xPlus = findViewById(R.id.xPlus);
        xPlus.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                xCounter += 1;
                xView.setText(Integer.toString(xCounter));
            }
        });

        Button xMinus = findViewById(R.id.xMinus);
        xMinus.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(xCounter > 0)
                {
                    xCounter -= 1;
                }
                xView.setText(Integer.toString(xCounter));
            }
        });

        Button yPlus = findViewById(R.id.yPlus);
        yPlus.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                yCounter += 1;
                yView.setText(Integer.toString(yCounter));
            }
        });

        Button yMinus = findViewById(R.id.yMinus);
        yMinus.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(yCounter > 0)
                {
                    yCounter -= 1;
                }
                yView.setText(Integer.toString(yCounter));
            }
        });

    }
}

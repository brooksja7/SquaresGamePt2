package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.mainmenu);

        Button mainStart = (Button) findViewById(R.id.mainStart);
        // Button mainStart = null;
        mainStart.setOnClickListener(view -> {
            Intent intent = new Intent(view.getContext(), gameSetup.class);
            startActivity(intent);
            //openGameSettings();
        });

        Button mainSetting = (Button) findViewById(R.id.mainSettings);
        mainSetting.setOnClickListener(view -> {
            Intent intent = new Intent(view.getContext(), generalSettings.class);
            startActivity(intent);
            //openGameSettings();
        });
    }
}

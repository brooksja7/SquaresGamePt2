package com.example.squaresgamept2;

import android.content.Intent;
import android.os.Bundle;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.view.View;

import android.view.Menu;
import android.view.MenuItem;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.mainmenu);


        /*****************************************************
         * Create a start button that when clicked will lead
         * the User to the game setup activity.
         ****************************************************/
        Button startBtn = findViewById(R.id.mainStart);
        startBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent gameSetupIntent = new Intent(getApplicationContext(), gameSetup.class);
                startActivity(gameSetupIntent);
            }
        });


        /*****************************************************
         * Create a settings button that when clicked will lead
         * the User to the settings activity.
         ****************************************************/
        Button settingsBtn = findViewById(R.id.mainSettings);
        settingsBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent settingsIntent = new Intent(getApplicationContext(), generalSettings.class);
                startActivity(settingsIntent);
            }
        });

    }
}

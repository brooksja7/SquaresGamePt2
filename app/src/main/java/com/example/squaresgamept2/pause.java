package com.example.squaresgamept2;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

public class pause extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.pausegame);

        /************************************************************************
         *  Declare and Initialize the buttons found on the pause-game screen
         *  Resume, settings, and exit button are on the pause screen.
         */
        Button resumeBtn = findViewById(R.id.RESUME);
        Button settingsBtn = findViewById(R.id.pauseSetting);
        Button exitBtn = findViewById(R.id.pauseExit);

        /************************************************************************
         *  When User clicks on the resume button, take the user back to the game page.
         */

        resumeBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent returnToGameIntent = new Intent(getApplicationContext(), game.class);
                startActivity(returnToGameIntent);
            }
        });

        /************************************************************************
         *  When User clicks on the settings button, take the user to the general settings page.
         */

        settingsBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent returnToSettingsIntent = new Intent(getApplicationContext(), generalSettings.class);
                startActivity(returnToSettingsIntent);
            }
        });

        /************************************************************************
         * When User clicks on the exit button, take the user to main menu page.
         */

        exitBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent returnToMainMenuIntent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(returnToMainMenuIntent);
            }
        });


    }
}

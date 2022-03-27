package com.example.squaresgamept2;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CompoundButton;
import android.widget.Switch;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.app.AppCompatDelegate;
import androidx.appcompat.widget.SwitchCompat;

import com.google.android.material.switchmaterial.SwitchMaterial;

public class generalSettings extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState){
        if(AppCompatDelegate.getDefaultNightMode() == AppCompatDelegate.MODE_NIGHT_YES)
        {
            setTheme(R.style.Theme_darkMode);
        }
        else
        {
            setTheme(R.style.Theme_SquaresGamePt2);
        }

        super.onCreate(savedInstanceState);
        setContentView(R.layout.generalsettings);


        /**************************************************************
         * Create buttons to activate their effects
         */
        Button exitBtn = findViewById(R.id.backGeneralSettings);
        Button musicBinary = findViewById(R.id.musicbinary);
        Button gameVolume = findViewById(R.id.gameSoundBinary);
        Button saveBtn = findViewById(R.id.Save);
        Switch darkModeSwitch = findViewById(R.id.darkModeSwitch);

        /**************************************************************
         * Create an onCLickListener when exitbtn is clicked this will lead the user back
         * to the main menu
         */

        exitBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent mainmenuIntent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(mainmenuIntent);
            }
        });

        // Change the button appearance when it is clicked to OFF
        // Vice versa
        musicBinary.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                if (musicBinary.getText().equals("OFF"))
                {
                    musicBinary.setText(R.string.ON);
                    musicBinary.setBackgroundResource(R.drawable.roundedbluebuttons);
                }
                else
                {
                    musicBinary.setText(R.string.OFF);
                    musicBinary.setBackgroundResource(R.drawable.roundedredbuttons);
                }
            }
        });

        // Change the button appearance when it is clicked to OFF
        // Vice versa
        gameVolume.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                if(gameVolume.getText().equals("OFF"))
                {
                    gameVolume.setText(R.string.ON);
                    gameVolume.setBackgroundResource(R.drawable.roundedbluebuttons);
                }
                else
                {
                    gameVolume.setText(R.string.OFF);
                    gameVolume.setBackgroundResource(R.drawable.roundedredbuttons);
                }
            }
        });

        // Tell the User his settings are saved when clicked
        saveBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Toast.makeText(getApplicationContext(), "Settings are Saved!", Toast.LENGTH_SHORT).show();
            }
        });
    }
}

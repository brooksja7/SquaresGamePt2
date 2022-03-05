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

        super.onCreate(savedInstanceState);
        setContentView(R.layout.generalsettings);

        Button exitBtn = findViewById(R.id.backGeneralSettings);
        Button musicBinary = findViewById(R.id.musicbinary);
        Button gameVolume = findViewById(R.id.gameSoundBinary);
        Button saveBtn = findViewById(R.id.Save);
        Switch darkModeSwitch = findViewById(R.id.darkModeSwitch);


        exitBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent mainmenuIntent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(mainmenuIntent);
            }
        });

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

        saveBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Toast.makeText(getApplicationContext(), "Settings are Saved!", Toast.LENGTH_SHORT).show();
            }
        });
    }
}

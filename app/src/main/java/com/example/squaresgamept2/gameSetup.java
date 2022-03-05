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

    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.gamesetup);

        Button exitBtn = findViewById(R.id.backGamesetup);
        exitBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent mainmenuIntent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(mainmenuIntent);
            }
        });

    }
}

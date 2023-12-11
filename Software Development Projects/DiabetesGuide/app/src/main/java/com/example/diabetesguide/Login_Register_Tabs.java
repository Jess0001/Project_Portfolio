package com.example.diabetesguide;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.util.Log;

import androidx.appcompat.app.AppCompatActivity;
import androidx.viewpager2.widget.ViewPager2;

import com.google.android.material.tabs.TabLayout;

public class Login_Register_Tabs extends AppCompatActivity implements TabLayout.OnTabSelectedListener {
    ViewPager2 viewpager;
    TabLayout tablayout;

    @SuppressLint("ResourceType")


    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login_register_tabs);

        tablayout = findViewById(R.id.loginTabLayout);
        viewpager = findViewById(R.id.loginViewPager);

        viewpager.setOrientation(ViewPager2.ORIENTATION_VERTICAL);
        com.example.diabetesguide.Adapter myAdapter = new com.example.diabetesguide.Adapter(getSupportFragmentManager(), getLifecycle());
        viewpager.setAdapter(myAdapter);

        viewpager.registerOnPageChangeCallback(new ViewPager2.OnPageChangeCallback() {
            @Override
            public void onPageScrolled(int position, float positionOffset, int positionOffsetPixels) {
                super.onPageScrolled(position, positionOffset, positionOffsetPixels);
            }

            @Override
            public void onPageSelected(int position) {
                super.onPageSelected(position);

                Log.e("Selected_Page", String.valueOf(position));
            }

            @Override
            public void onPageScrollStateChanged(int state) {
                super.onPageScrollStateChanged(state);
            }
        });

    }

    public void selectPage(int pageIndex) {
        tablayout.setScrollPosition(pageIndex, 0f, true);
        viewpager.setCurrentItem(pageIndex);
    }

    @Override
    public void onTabSelected(TabLayout.Tab tab) {

        viewpager.setCurrentItem(tab.getPosition());
    }

    @Override
    public void onTabUnselected(TabLayout.Tab tab) {

    }

    @Override
    public void onTabReselected(TabLayout.Tab tab) {

    }
}
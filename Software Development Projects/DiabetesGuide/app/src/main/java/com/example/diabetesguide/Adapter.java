package com.example.diabetesguide;


import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.lifecycle.Lifecycle;
import androidx.viewpager2.adapter.FragmentStateAdapter;


public class Adapter extends FragmentStateAdapter {

    //private ArrayList<Fragment> fragmentList = new ArrayList<>();
      //TabLayout tab_log, tab_reg;
    public Adapter(@NonNull FragmentManager fragmentManager, @NonNull Lifecycle lifecycle) {
        super(fragmentManager, lifecycle);
    }


    @NonNull
    @Override
    public Fragment createFragment(int position) {
        Fragment fragment = null;
        if (position == 0) {
            return new login_fragment();
        }
          else if (position == 1) {
                return new register_fragment();
          }
            return createFragment(position);
        }




    @Override
    public int getItemCount() {
        return 2;
    }
}
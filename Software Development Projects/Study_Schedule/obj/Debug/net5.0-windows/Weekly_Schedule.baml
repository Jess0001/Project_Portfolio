   M S B A M L   `   `   `  ����I  EStudy_Schedule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Study_PlannerStudy_Planner  5   	   #    Study_Planner.Weekly_Schedule   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Study_Planner     5   	     � Title$  Weekly_Schedule��5   	   $	��650��6!   $
��1000��6.   .��5	      � ��5
   
   �� 5       �� ImageSource$# /background-study-cartoon.jpg��6   .+�5   
   �� $ ��Self-Study Weekly Schedule��6   $��Center=�65   $	��Top=�6R   $��48(�6j   $
��Bold"�6x   $��Lucida Sans Typewriter)�6�   
���   �$��0,16,0,0q�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF685C5C��6#    � Offset$ 0.897Q�65   � 5      $ White��6#   $
 0.11Q�61   � 5      $ 	#FF5385B8��6#   $ 0.727Q�65   � 5      $ 	#FFE0E01B��6#   $ 0.577Q�65   � 5      $ 	#FFE6C9B2��6#   $ 0.397Q�65   � 5      $ 	#FF342E28��6#   $
 0.23Q�65   � 5      $ 	#FFD31C5F��6#   $ 0Q�65   � 5      $ 	#FEC0E4AF��6#   $ 0.933Q�65   � 5      $ 	#FED82121��6#   $
 0.85Q�65   � 5      $ 	#FE12C997��6#   $ 1Q�65   � 5      $ 	#FF531028��6#   $
 0.49Q�65   � 5      $ 	#FEC92BC9��6#   $
 0.78Q�65   � 5      $ 	#FF242B25��6#   $ 0.663Q�65   � 5      $ 	#FFB9B9B9��6#   $ 0.297Q�65   � 5      $ 	#FFB6B2B3��6#   $ 0.173Q�65   5      5!      �� 5"   
   $��Module��6   $
��Left=�6!   $��147,227,0,0q�6<   $	��Top=�6Q   $��24(�6i   
�������$
��Bold"�6�   �� 5#   
   $��Weekly hours��6   $
��Left=�6'   $��245,227,0,0q�6B   $	��Top=�6W   $��24(�6o   
�������$
��Bold"�6�   �� 5$   
   $��Completed hours��6   $
��Left=�6*   $��408,227,0,0q�6E   $	��Top=�6Z   $��24(�6r   
�������$
��Bold"�6�   �� 5%   
   $��Remaining hours��6   $
��Left=�6*   $��662,227,0,0q�6E   $	��Top=�6Z   $��24(�6r   
�������$
��Bold"�6�   �� 5&   
   -   5         ��Name$ startSemester��5&      $��Semester Start:��6'   $
��Left=�6A   $��147,126,0,0q�6\   $	��Top=�6q   $��22(�6�   
�������$
��Bold"�6�   �� 5'   
   $��Semester End:��6   $
��Left=�6(   $��147,170,0,0q�6C   $	��Top=�6X   
�������$��22(�6�   $
��Bold"�6�   �� 5(   
   -   5         ��Name$ semesterStart��5(      $
��Left=�6+   $��333,130,0,0q�6F   $
��Wrap=�6[   $	��Top=�6o   
�������$��22(�6�   $	��200��6�   ��6�   ��  �� Path$ DateTimeValue�	 �� StringFormat$	 
dd-MM-yyyy���� 5)   
   -   5        $ endSemester��5)      $
��Left=�6)   $��333,175,0,0q�6D   $
��Wrap=�6Y   $	��Top=�6m   $��22(�6�   
�������$	��200��6�   ��6�   �� $ DateTimeValue�$	 
dd-MM-yyyy���� 5*   
   -   5        
 ��Name$

 exit��5*      $
��Exit��6   $
��Left=�6.   $��843,559,0,0q�6I   $	��Top=�6^   $	��120��6v   $��40��6�    J� Effect 5+      3  -System.Windows.Media.Effects.DropShadowEffect  5,      5.      �� 5/   
   -   5         ��Name$ schedule��5/      $��147,274,119,272q�6)   $��22(�6B   
�������6P   51      52      
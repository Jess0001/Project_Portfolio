   M S B A M L   `   `   `  ����I  EStudy_Schedule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Study_PlannerStudy_Planner  5   	   !    Study_Planner.Studied_Hours   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Study_Planner     5   	     � Title$  Studied_Hours��5   	   $	��450��6   $	��800��6,   .��5	      � -   5         �Name$ study_Query��5	      ��5
   
   �� 5       �� ImageSource$$ /background-study-cartoon4.jpg��6   .+�5   
   �� -   5         ��Name$ 
studyQuery��5      $
��Wrap=�6(   $��25,15,25,529q�6<   $	��750��6R   $��Lucida Sans Typewriter)�6^   $��72(�6�   ���	#FFFFFBFB$	��190��6�   �� 5   
   $��Hours studied:��6   $
��Left=�6)   $��
25,224,0,0q�6D   $	��Top=�6X   $��36(�6p   
�������$	��240��6�   $��55��6�   �� 5   
   -   5         ��Name$ hoursStudied��5      $
��Left=�6(   $��301,228,0,0q�6C    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��120��6�   $��33(�6�   $��55��6�   �� 5   
   -   5         ��Name$ next5��5      $
��Next��6    $
��Left=�6/   $��635,365,0,0q�6J   $	��Top=�6_   $	��120��6w   $��40��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   $��Date:��6   $
��Left=�6    $��
25,306,0,0q�6;   $	��Top=�6O   $��36(�6g   
�������6u   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ sDate��5      $
��Left=�6$   $��145,318,0,0q�6?   $	��Top=�6T   	   SelectedDateFormat$
	 Long=�6l   $��20(�6�   5      5      
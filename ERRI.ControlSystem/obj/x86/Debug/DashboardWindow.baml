   M S B A M L   `   `   `  ����N  JEERIL.ControlSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:EERIL.ControlSystem.PropertiesEERIL.ControlSystem.Properties  5   	   9!clr-namespace:EERIL.ControlSystemEERIL.ControlSystem  5   P   )    #EERIL.ControlSystem.DashboardWindow   5   	   2xctk)http://schemas.xceed.com/wpf/xaml/toolkit  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   C
properties,clr-namespace:EERIL.ControlSystem.Properties     5   	   0my!clr-namespace:EERIL.ControlSystem     5   P   -   5          � Title$  MSLED Dashboard��5   	   $	��472��6!   $	��870��6.   .��5      � -   5        $��dashboardGrid��5       � ColumnDefinitions 5   
   �� 5      �� 5	      $	��228 �6    � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      -   5         �Name$ 	serialRow��5      $
��Auto �6-   .+�5   
   ]� -   5        $��RightContentPanel��5      ��. $��3��6B   $��1��6S   $��Right=�6d   $��2��6{   $	��5,0q�6�   .+�5      �� -   5        $��recordVideoButton��5      $	��Top=�6.   $��23��6C   $��Stretch=�6O   $��Record Video��6m   $��
0, 5, 0, 0q�6�   $��Center=�6�   $��1q�6�   6�   �� 5      -   5        $��
powerPanel��5      $	��Top=�6+    �� Orientation$ 
Horizontal=�6@   $��Stretch=�6Y   $��	0,5, 0, 0q�6w   .+�5      �� -   5        $��
powerLabel��5      $��Power Level:��6*   $��28��6A   �� 5      -   5        $��powerComboBox��5      $��Stretch=�60   $	��142��6N   $��23��6�   .@�5      �� $
��Full��6#   
 � Tag$ 0��62    �� 
IsSelected . 6:   �� 5      $��No Buoyancy��6#   $ 1��69   �� 5      $��Sleep��6#   $ 2��63   5      5      �� 5      -	   5        $��illuminationPanel��5      $	��Top=�62   $ 
Horizontal=�6G   $��Stretch=�6`   $��0,5,0,0q�6~   .+�5      �� -
   5        $��illuminationLabel��5      $��Illumination:��61   $��28��6I   �� 5      -   5        $��illuminationSlider��5   %   $��23��6    � Minimum$ 0Q�6?    � Maximum$	 255Q�6K   $	��142��6Y   $��Stretch=�6e   	 � Value	 6�   �� -  'EERIL.ControlSystem.Properties.Settings
   Default �� Source# Z
  �� Path$ illumination�5      �� 5      -   5        $��
statePanel��5      $	��Top=�6,   $ 
Horizontal=�6A   $��Stretch=�6Z   $��0,5,0,0q�6x   .+�5       �� -   5        $��
stateLabel��5       $��Controller State:��6*   $��28��6F   �� 5!      -   5        $��state��5!      ��6%   �� # Z
 $! connectionConnectionChanged�5"      5%      �� 5&   
   -   5        $��primaryTabControl��5&      $��0��6.   $��0��6;   .@�5'      �� -   5        $��calibrationsTabItem��5'   <   $"��Physical Device Calibrations��6   .��5(      �� -   5        $��OffsetPanel��5(      $	��250��60   .+�5)      �� -   5        $��
FocusPanel��5)   !   $	��250��63   $ 
Horizontal=�6A   .+�5*      �� -   5        $��
focusLabel��5*       $��Focus:��62   $��28��6C   $	��105��6O   �� 5+      -   5        $��focusSlider��5+   -   $��23��6!   $	��145��6@   $ 0Q�6L   $	 102Q�6X   	 6f   �� # Z
 $ focusPosition�5,   5   5-      �� 5.      -   5        $��ResetFocusPanel��5.   -   $��50��6!   $	��250��6D   $ 
Horizontal=�6P   .+�5/      �� -   5        $��
resetFocus��5/   "   $��23��64   $��40��6@   6M   �� 50      -   5        $��resetFocusButton��50   !   $��Reset Focus��69   $��23��6O   $��80��6[   6�   53      �� 54      -   5        $��BuoyancyPanel��54   !   $	��250��66   $ 
Horizontal=�6D   .+�55      �� -   5        $��buoyancyLabel��55       $��	Buoyancy:��65   $��28��6I   $	��105��6U   �� 56      -   5        $��buoyancySlider��56   -   $��23��6!   $	��145��6C   $ 0Q�6O   $	 162Q�6[   	 6i   �� # Z
 $ buoyancyPosition�57   8   58      �� 59      -   5        $��InvertThrustPanel��59   -   $��25��6!   $	��250��6F   .+�5:      �� -   5        $��invertThrustToggleButton��5:   #   $��Center=�6C   $��Invert Thrust Control��6`   $��Center=�6�   $��1q�6�   5<      �� 5=      -   5        $��HeadingOffsetPanel��5=   !   $ 
Horizontal=�6;   .+�5>      �� $��Heading Offset:��6    $��28��6:   $	��105��6F   �� 5?      -   5        $��YawOffsetSlider��5?   -   $��23��6!   $	��145��6D   $ -5Q�6P   $ 5Q�6]   	 6i   �� # Z
 $ 	YawOffset�5A      �� 5B      -   5        $��PitchOffsetPanel��5B   !   $ 
Horizontal=�69   .+�5C      �� $��Pitch Offset:��6    $��28��68   $	��105��6D   �� 5D      -    5        $��PitchOffsetSlider��5D   -   $��23��6!   $	��145��6F   $ -5Q�6R   $ 5Q�6_   	 6k   �� # Z
 $ PitchOffset�5F      �� 5G      -!   5        $��OffsetPanel2��5G   !   $	��250��65   .+�5I      �� -"   5        $��FinRangePanel��5I   %   $ 
Horizontal=�6:   .+�5J      �� $��
Fin Range:��6$   $��28��69   $	��105��6E   �� 5K      -#   5        $��FinRangeSlider��5K   1   $��23��6%   $	��145��6G   $ 0Q�6S   $ 28Q�6_    �� IsMoveToPointEnabled .   �� IsSnapToTickEnabled .   �� IsSelectionRangeEnabled .  	 6l   �� # Z
 $ FinRange�5L   i   5M      �� 5N      -$   5        $��TopFinOffsetPanel��5N   %   $ 
Horizontal=�6>   .+�5O      �� $��Top Fin Offset:��6$   $��28��6>   $	��105��6J   �� 5P      -%   5        $��TopFinOffsetSlider��5P   1   $��23��6%   $	��145��6K   $ 0Q�6W   $	 180Q�6c   	 6q   �� # Z
 $ TopFinOffset�5R      �� 5S      -&   5        $��RightFinOffsetPanel��5S   %   $ 
Horizontal=�6@   .+�5T      �� $��Right Fin Offset:��6$   $��28��6@   $	��105��6L   �� 5U      -'   5        $��RightFinOffsetSlider��5U   1   $��23��6%   $	��145��6M   $ 0Q�6Y   $	 180Q�6e   	 6s   �� # Z
 $ RightFinOffset�5W      �� 5X      -(   5        $��BottomFinOffsetPanel��5X   %   $ 
Horizontal=�6A   .+�5Y      �� $��Bottom Fin Offset:��6$   $��28��6A   $	��105��6M   �� 5Z      -)   5        $��BottomFinOffsetSlider��5Z   1   $��23��6%   $	��145��6N   $ 0Q�6Z   $	 180Q�6f   	 6t   �� # Z
 $ BottomFinOffset�5\      �� 5]      -*   5        $��LeftFinOffsetPanel��5]   %   $ 
Horizontal=�6?   .+�5^      �� $��Left Fin Offset:��6$   $��28��6?   $	��105��6K   �� 5_      -+   5        $��LeftFinOffsetSlider��5_   1   $��23��6%   $	��145��6L   $ 0Q�6X   $	 180Q�6d   	 6r   �� # Z
 $ LeftFinOffset�5a      5b      5d      5e      �� 5g      -,   5        $��dashboardTabItem��5g   )   $��	Dashboard��6   .��5h      � --   5        $��maingrid��5h      .+�5i      �� $��mapping.jpg��6   $��UniformTofill=�61   5j      5k      5l      �� 5n   
   $��1��5o      $��0��5p      $��Stretch=�5q      $��Center=�5r       �� ShowsPreview . $��5��5t      �� 5u   
   -.   5        $��serialScrollViewer��5u      $��2��61   $��0��6>   .��5v      �� -/   5        $��serialTextBlock��5v      ��. $
��Auto=�6T   $��Visible=�6�   5w      5x      5y      
   M S B A M L   `   `   `  ���� N  JEERIL.ControlSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:EERIL.ControlSystem.PropertiesEERIL.ControlSystem.Properties  9!clr-namespace:EERIL.ControlSystemEERIL.ControlSystem  )    #EERIL.ControlSystem.DashboardWindow   2xctk)http://schemas.xceed.com/wpf/xaml/toolkit  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     C
properties,clr-namespace:EERIL.ControlSystem.Properties     0my!clr-namespace:EERIL.ControlSystem     -     � Title$  MSLED Dashboard��$	��472��$	��870��.��� -   $��dashboardGrid�� � ColumnDefinitions �� �� $	��228 � � RowDefinitions �� �� $
��Auto ��� -    �Name$ 	serialRow��$
��Auto �.+�]� -   $��RightContentPanel����. $��3��$��1��$��Right=�$��2��$	��5,0q�.+��� -   $��recordVideoButton��$	��Top=�$��23��$��Stretch=�$��Record Video��$��
0, 5, 0, 0q�$��Center=�$��1q��� -   $��
powerPanel��$	��Top=� �� Orientation$ 
Horizontal=�$��Stretch=�$��	0,5, 0, 0q�.+��� -   $��
powerLabel��$��Power Level:��$��28���� -   $��powerComboBox��$��Stretch=�$	��142��$��23��.@��� $
��Full��
 � Tag$ 0�� �� 
IsSelected . �� $��No Buoyancy��$ 1���� $��Sleep��$ 2���� -	   $��illuminationPanel��$	��Top=�$ 
Horizontal=�$��Stretch=�$��0,5,0,0q�.+��� -
   $��illuminationLabel��$��Illumination:��$��28���� -   $��illuminationSlider��$��23�� � Minimum$ 0Q� � Maximum$	 255Q�$	��142��$��Stretch=�	 � Value	 �� -  'EERIL.ControlSystem.Properties.Settings
   Default �� Source# Z
  �� Path$ illumination��� -   $��
statePanel��$	��Top=�$ 
Horizontal=�$��Stretch=�$��0,5,0,0q�.+��� -   $��
stateLabel��$��Controller State:��$��28���� -   $��state������ # Z
 $! connectionConnectionChanged��� -   $��primaryTabControl��$��0��$��0��.@��� -   $��calibrationsTabItem��$"��Physical Device Calibrations��.���� -   $��OffsetPanel��$	��250��.+��� -   $��
FocusPanel��$	��250��$ 
Horizontal=�.+��� -   $��
focusLabel��$��Focus:��$��28��$	��105���� -   $��focusSlider��$��23��$	��145��$ 0Q�$	 102Q�	 �� # Z
 $ focusPosition��� -   $��ResetFocusPanel��$��50��$	��250��$ 
Horizontal=�.+��� -   $��
resetFocus��$��23��$��40���� -   $��resetFocusButton��$��Reset Focus��$��23��$��80���� -   $��BuoyancyPanel��$	��250��$ 
Horizontal=�.+��� -   $��buoyancyLabel��$��	Buoyancy:��$��28��$	��105���� -   $��buoyancySlider��$��23��$	��145��$ 0Q�$	 162Q�	 �� # Z
 $ buoyancyPosition��� -   $��InvertThrustPanel��$��25��$	��250��.+��� -   $��invertThrustToggleButton��$��Center=�$��Invert Thrust Control��$��Center=�$��1q��� -   $��HeadingOffsetPanel��$ 
Horizontal=�.+��� $��Heading Offset:��$��28��$	��105���� -   $��YawOffsetSlider��$��23��$	��145��$ -5Q�$ 5Q�	 �� # Z
 $ 	YawOffset��� -   $��PitchOffsetPanel��$ 
Horizontal=�.+��� $��Pitch Offset:��$��28��$	��105���� -    $��PitchOffsetSlider��$��23��$	��145��$ -5Q�$ 5Q�	 �� # Z
 $ PitchOffset��� -!   $��OffsetPanel2��$	��250��.+��� -"   $��FinRangePanel��$ 
Horizontal=�.+��� $��
Fin Range:��$��28��$	��105���� -#   $��FinRangeSlider��$��23��$	��145��$ 0Q�$ 28Q� �� IsMoveToPointEnabled .   �� IsSnapToTickEnabled .   �� IsSelectionRangeEnabled .  	 �� # Z
 $ FinRange��� -$   $��TopFinOffsetPanel��$ 
Horizontal=�.+��� $��Top Fin Offset:��$��28��$	��105���� -%   $��TopFinOffsetSlider��$��23��$	��145��$ 0Q�$	 180Q�	 �� # Z
 $ TopFinOffset��� -&   $��RightFinOffsetPanel��$ 
Horizontal=�.+��� $��Right Fin Offset:��$��28��$	��105���� -'   $��RightFinOffsetSlider��$��23��$	��145��$ 0Q�$	 180Q�	 �� # Z
 $ RightFinOffset��� -(   $��BottomFinOffsetPanel��$ 
Horizontal=�.+��� $��Bottom Fin Offset:��$��28��$	��105���� -)   $��BottomFinOffsetSlider��$��23��$	��145��$ 0Q�$	 180Q�	 �� # Z
 $ BottomFinOffset��� -*   $��LeftFinOffsetPanel��$ 
Horizontal=�.+��� $��Left Fin Offset:��$��28��$	��105���� -+   $��LeftFinOffsetSlider��$��23��$	��145��$ 0Q�$	 180Q�	 �� # Z
 $ LeftFinOffset��� -,   $��dashboardTabItem��$��	Dashboard��.��� --   $��maingrid��.+��� $��mapping.jpg��$��UniformTofill=��� $��1��$��0��$��Stretch=�$��Center=� �� ShowsPreview . $��5���� -.   $��serialScrollViewer��$��2��$��0��.���� -/   $��serialTextBlock����. $
��Auto=�$��Visible=�
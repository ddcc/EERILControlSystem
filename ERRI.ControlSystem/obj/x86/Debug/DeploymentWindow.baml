   M S B A M L   `   `   `  ����  EERIL.ControlSystem*    $EERIL.ControlSystem.DeploymentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  MSLED Deployment Panel��5   	   $	��278��6(   $	��500��65    � WindowStartupLocation$ CenterOwner=�6A    � Topmost .  $	��500��6u   $	��278��6�    � SizeToContent$ WidthAndHeight=�6�    � 
ResizeMode$ NoResize=�6�   .��5      ]� ��. $	��238��6%   $	��476��62   .+�5   
   ]� -   5        $��controlPanel��5      $
��Left=�6(   $	��200��6>   ��. $��
12,12,0,12q�6_   .+�5      �� -   5        $��missionLabel��5   ;   $	��Top=�6   $��Mission��6)   5	      �� 5
      -   5        $��addMissionPanel��5
   1   $��Bottom=�6    �� Orientation$ 
Horizontal=�6H   $��0,12,0,0q�6a   .+�5      �� -   5        $��addMissionTextBox��5   &   $��23��6   $	��125��6?   �� 5      -   5        $��addMissionButton��5   ;   $��Add Mission��6   $��23��6/   $��75��6S   6^   5      �� 5      -   5        $��missionList��5       �� DisplayMemberPath$
 Name��6�    �� SelectionMode$ Single=�6�   ��6)   �� *
Missions+ �� Source �� *FindAncestor+	 �� AncestorType$	 ApplicationL�
 �� Mode$
 OneWay=�6�   5      �� 5   
   $��12q�6   .+�5      �� -   5        $��dateTimeLabel��5   4   $��	Date/Time��6   $��28��6(   64   �� 5      -	   5        $��dateTimeTextBox��5   "   $��23��6   $	��120��69   $
��Left=�6E   �� 5      -
   5        $��
notesLabel��5   0   $��Notes��6   $��28��6$   60   �� 5      -   5        $��notesRichTextBox��5   '   $	��100��6   $��Stretch=�6?   $��Stretch=�6d   �� 5      -   5        $��deploymentButtonPanel��5      $ 
Horizontal=�66   $��Right=�6O   $��Center=�6k   .+�5      �� -   5        $��deployButton��5   6   $��Deploy��6   $��23��6*   $��75��6J   $��12, 12, 0, 0q�6p   $��Right=�6�   {�.   �� 	IsDefault . 6�   �� 5      -   5        $��cancelButton��5   6   $��Cancel��6   $��23��6*   $��75��6J   $��12, 12, 0, 0q�6U   $��Right=�6k   {�.  .   �� IsCancel . 6�   5      5      5      5      
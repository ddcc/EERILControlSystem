   M S B A M L   `   `   `  ����   EERIL.ControlSystem*    $EERIL.ControlSystem.DeploymentWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  MSLED Deployment Panel��$	��278��$	��500�� � WindowStartupLocation$ CenterOwner=� � Topmost .  $	��500��$	��278�� � SizeToContent$ WidthAndHeight=� � 
ResizeMode$ NoResize=�.��]� ��. $	��238��$	��476��.+�]� -   $��controlPanel��$
��Left=�$	��200����. $��
12,12,0,12q�.+��� -   $��missionLabel��$	��Top=�$��Mission���� -   $��addMissionPanel��$��Bottom=� �� Orientation$ 
Horizontal=�$��0,12,0,0q�.+��� -   $��addMissionTextBox��$��23��$	��125���� -   $��addMissionButton��$��Add Mission��$��23��$��75���� -   $��missionList�� �� DisplayMemberPath$
 Name�� �� SelectionMode$ Single=����� *
Missions+ �� Source �� *FindAncestor+	 �� AncestorType$	 ApplicationL�
 �� Mode$
 OneWay=��� $��12q�.+��� -   $��dateTimeLabel��$��	Date/Time��$��28���� -	   $��dateTimeTextBox��$��23��$	��120��$
��Left=��� -
   $��
notesLabel��$��Notes��$��28���� -   $��notesRichTextBox��$	��100��$��Stretch=�$��Stretch=��� -   $��deploymentButtonPanel��$ 
Horizontal=�$��Right=�$��Center=�.+��� -   $��deployButton��$��Deploy��$��23��$��75��$��12, 12, 0, 0q�$��Right=�{�.   �� 	IsDefault . �� -   $��cancelButton��$��Cancel��$��23��$��75��$��12, 12, 0, 0q�$��Right=�{�.  .   �� IsCancel . 
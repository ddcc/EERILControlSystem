   M S B A M L   `   `   `  ����N  JEERI.DeviceControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullX?clr-namespace:EERIL.DeviceControls;assembly=EERI.DeviceControlsEERIL.DeviceControls  5   	   N JEERIL.ControlSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EERIL.ControlSystemEERIL.ControlSystem 5   	   ,   &EERIL.ControlSystem.VideoDisplayWindow   5   	   Fmy?clr-namespace:EERIL.DeviceControls;assembly=EERI.DeviceControls  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   1local!clr-namespace:EERIL.ControlSystem    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   ~   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   -   5          � Title$  Video Display��5   	   
������� � WindowStartupLocation$ CenterScreen=�6H   $
��1024��6  $
��1360��6  .��5   
   � -   5        $��canvas��5      
���   �.+�5   
   �� -   5        $��
videoImage��5      $
��None=�6�    J� IsHitTestVisible .  ��6"   �� *ActualWidth+ �� ElementName$ canvas����6T   �� *ActualHeight+$ canvas��6�   (   "EERIL.DeviceControls.HeadUpDisplay  5   
   -   5        $��headsUpDisplay��5      ��61   �� *ActualWidth+$ canvas����6c   �� *ActualHeight+$ canvas��5	      5
      
   M S B A M L   `   `   `  ����O  KCarSharingManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CarSharingManagementCarSharingManagement  5   	   '    !CarSharingManagement.AddCarWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:CarSharingManagement     5   	     � Title$  Car Modifier��5   	   $	��450��6   $	��507��6+   .��5	      � $��0,0,32,0q�6    � ColumnDefinitions 5
   
   �� 5      $	��33* �6   �� 5      $
��367* �6   .+�5   
   �� -   5         ��Name$ CarBrandTextBox��5      $��1��6+   $
��Left=�6;   $��102,114,0,0q�6V    �� TextWrapping$
 Wrap=�6k   $��Brand��6   $	��Top=�6�   $	��220��6�   $��26��6�   6�   �� 5   
   -   5         ��Name$ CarColorComboBox��5      $��1��6-   $
��Left=�6=   $��101,207,0,0q�6X   $	��Top=�6m   $	��222��6�   $��23��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.101Q�6&   T� 5      5      5      �� 5   
   -   5        $ CarEquipmentComboBox��5      $��1��61   $
��Left=�6A   $��102,255,0,0q�6\   $	��Top=�6q   $	��220��6�   $��23��6�   6�   �� 5   
   -   5        $ CarMechanicComboBox��5      $��1��60   $
��Left=�6@   $��102,303,0,0q�6[   $	��Top=�6p   $	��220��6�   6�   �� 5   
   -   5         ��Name$ AcceptCarButton��5      $��1��6*   $��Apply��6:   $
��Left=�6J   $��232,366,0,0q�6e   $	��Top=�6z   $��90��6�   6�   �� 5   
   -   5        $ CancelCarButton��5      $��1��6*   $��Cancel��6:   $
��Left=�6K   $��102,366,0,0q�6f   $	��Top=�6{   $��81��6�   6�   �� 5   
   -   5         ��Name$ CarModifierLabel��5      $��1��6*   $%��Enter proper info about the car��6:   $��
102,48,0,0q�6d   $	��Top=�6x   $	��220��6�   $
��Left=�6�   $��Center=�6�   �� 5   
   -   5        $ CarModelTextBox��5      $��1��6+   $
��Left=�6;   $��102,161,0,0q�6V   $
 Wrap=�6k   $��Model��6   $	��Top=�6�   $	��220��6�   $��27��6�   6�   5       5!      
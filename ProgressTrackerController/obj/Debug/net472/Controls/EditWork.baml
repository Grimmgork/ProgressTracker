   M S B A M L   `   `   `  ����J  FProgressTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ProgressTracker.ControlsProgressTracker.Controls  5      '    !ProgressTracker.Controls.EditWork   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:ProgressTracker.Controls     5        J� SnapsToDevicePixels$
  True��5   0   .��5
      � $	��250��6   $	��180��6   .+�5   
   ��    MiddlegroundColor#��[  6   � 5   
   $��8q�6    � ColumnDefinitions 5      �� 5      �� 5       � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��8 �6    �� 5      $
��Auto �6    �� 5      $��8 �6    �� 5      $
��Auto �6    �� 5      $��40 �6    �� 5      $
��Auto �6    .+�5      �� $
��Name��6   $��Center=�6$     TextNormalColor#��[ 6?   �� 5      $��1��6,     TextLightColor#��[ 6<    � Cursor$ IBeam��6i   ��6   �� *Name+6i   +   %ProgressTracker.Controls.NumericInput  5      $��1��6F   $��2��6V   
   Max$ 99999999��6c   
   Min$ 0��6r      Value 6!   �� *Total+ �� Mode$ TwoWay=�6r     5       $��1��6M   $��4��6]   $ 99999999��6j   $ 0��6y    6!   �� *CurrentValue+$ TwoWay=�6y   �� 5"      $��Total steps��6   $��Center=�6+   $��2��6F   #��[ 6S   �� 5#      $��Completed steps��6   $��Center=�6/   $��4��6J   #��[ 6W   5$      �� 5&   
   $��Stretch=�6   $��6��6/   $��2��6<     PrimaryButtonStyle#��[ 6P   $��Bottom=�6�   $��Apply��6�   $
 Hand��6�   $��32��6�   $��0,0,0,8q�6�   ��6|   �� *
CMDApply+6�   5'      5)      
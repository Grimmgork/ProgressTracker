   M S B A M L   `   `   `  ����J  FProgressTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProgressTrackerProgressTracker  5   	   =#clr-namespace:ProgressTracker.ModelProgressTracker.Model  5   	   C&clr-namespace:ProgressTracker.ControlsProgressTracker.Controls  5   	   "    ProgressTracker.ProgressEdit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProgressTracker     5   	   4mdls#clr-namespace:ProgressTracker.Model     5   	   8ctrls&clr-namespace:ProgressTracker.Controls     5   	   -   5        $	��450��5
   )   $	��400��66     � 
ResizeMode$  CanMinimize=�6B      BackgroundColor#��[  6t    J� SnapsToDevicePixels$
 True��6�     TextFont#��[ 5   	    � WindowStyle$
 None=�5   	    � Title 5
   	   �� *Proj.FileName+ � 	Resources 5       �� DataType&    ProgressTracker.Model.LinearWork � RowDefinitions J� Opacity  SuccessColor � Value  TextLightColor	 ��Name
 �� Orientation  TextNormalColor ��Name  
SymbolFont � ToolTip �� Triggers �� Value �� Binding �� Path �� 
TargetName �� Property �� Value��%[  (��       5      *, +)7  7  7  7  7  7  �� 6
   "  6   .R�5      �� $	��Top=�6   ._�5      �  5      �� 5      �� 5      $��4 �6(   .+�5      �� $��1��6   
���   �$	 0.1Q�6=   � 5      $��1��6"   8��  
������  6/   �� *
Percentage+6w   � 5      $��12q�6   .+�5      �� 8�� $��16(�6g   $��Center=�6u   ��6$   �� *Name+6u   �� 5      $	 TextPercentage��6%   $��Right=�6=   $��Center=�6Y   $
 
Horizontal=�6t   .+�5      �� 8�� $��16(�6q   ��6(   �� *
Percentage+6q   �� 5      $��%��6(   8�� $��16(�6_   5       �� 5"      $ TextCheckmark��6$   $��Right=�6;   $��Center=�6W   $��18(�6r   $��Medium"�6�   $	����6�   8�� 8�� $ 
Completed!��6�   5#      5$      5%       5'      �� 5(      $
 True��6A    6   �� $ 	Completed�.a�5)      �� $ TextPercentage��6    � y�$ Hidden=�6O   5*      �� 5,      $ False��6A    6   �� $ 	Completed�.a�5-      �� $ TextCheckmark��6    � y�$ Hidden=�6N   5.      50      51      .��53      ��   PrimaryColor#��[ 6   $��1q�69   ._�54      �  55   
   �� 56      $��32 �6   �� 57      $��8 �6   �� 58      �� 59      $
��Auto �6   .+�5<   
   ��   ForegroundColor#��[ 6   �� 5=   
   $��Center=�63   $��Medium"�6P   $��Center=�6e   $	��110��6�   #��[ 6�   ��6   �� *Proj.FileName+6�   �� 5>   
   -   5        
������ 5>   ,   �� 5@   
   $
 
Horizontal=�6   $
��Left=�6.   .+�5A      �� $��32��6   $	����6    $��16(�63   #��[ 6A    � Cursor$
 Hand��6j     TransparentButtonStyle#��[ 6�   $ Open project��6�   ��6x   �� *CMDOpenProject+6�   �� 5B      $��32��6   $	����6    $��16(�63   #��[ 6A   $
 Hand��6j   #��[ 6�   $ Create project��6�   ��6x   �� *CMDCreateProject+6�   �� 5C      $��32��6   $	����6    $��16(�63   #��[ 6A   $
 Hand��6j   #��[ 6�   $
 Save��6�   ��6x   �� *	CMDSave+{�6�   �� *
HasChanges+6�   5D      �� 5F   
   $
 
Horizontal=�6   $��Right=�6.   .+�5G      �� -   5        $��40��5G      $	����6    #��[ 6D   #��[ 6n   �� 5H      -   5        $��40��5H      $	����6    #��[ 6A   #��[ 6j   5I      �� 5K   
   $��1��6   $��2��6!   $��Hello there!��62   $��Center=�6g   $��Center=�6�   $
��Bold"�6�   #��[ 6�   $��16(�6�   {�6F   �� *
HasProject+6�   �� 5L   
   $��1��6   $��2��6   ��60   �� *	Proj.Work+��5M      �� 5N       �� 
TargetType" ��6   .�5O      -   5        �� 5P       � �� 5Q      �� 5R        �� 
TargetType" ��60   .R�5S   $   �  	 MiddlegroundColor#��[	 6)   $
 Hand��6Y   .+�5T   (   ��  ��Name$
 Rect��62   $��8��6@    
 HighlightColor#��[
 6N   $y�Hidden=�6u   �� 5U   (   $��1��69    J� IsHitTestVisible$ False��6I   5V   %    �� Triggers 5X   $   P� 5Y   (    P� Property �@J�IsMouseOver P� Value$
 True��6G   . �5Z   ,   �� $
 Rect��63    � y�$ Visible=�6[   5[   )   5]       5_      5`      5b      �� 5d   
   $��1��6   $ False��6!   ��5e      �� 5f       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 0,1&�67    �� Opacity$	 0.1Q�6F   .��5g      �  � Color$ Black��6#     � Offset$  0Q�61   � 5h      $ 	#00000000��6#   $  1Q�65   5i      5k      �� 5m   
   $��3��6   #��[ 6   ._�5n      �� $
 
Horizontal=�6   .+�5o      �� $��24��6   $��24��6%   $��0��61   $	����6?   $
��Left=�6R   #��[ 6m   #��[ 6�   $ Reload file��6  ��6�   �� *	CMDReload+{�6�   �� *
HasProject+6  �� 5p        TextDarkColor#��[ 6:   $��10(�6f   $��Center=�6t   $
��Left=�6�   $��4,0,0,0q�6�   $��Medium"�6�   ��6   �� *Proj.Status+6�   5q      5r      #   ProgressTracker.OverlayHolder  5t      #   ProgressTracker.OverlayHolder!   LockAreaClick$!! OverlayHolder_LockAreaClick��63   $��4��6"   63   5u      5v      5w      
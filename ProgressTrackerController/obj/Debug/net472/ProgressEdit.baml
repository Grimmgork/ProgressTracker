   M S B A M L   `   `   `  ����J  FProgressTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProgressTrackerProgressTracker  5   	   =#clr-namespace:ProgressTracker.ModelProgressTracker.Model  5   	   C&clr-namespace:ProgressTracker.ControlsProgressTracker.Controls  5   	   "    ProgressTracker.ProgressEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProgressTracker     5   	   4mdls#clr-namespace:ProgressTracker.Model     5   	   8ctrls&clr-namespace:ProgressTracker.Controls     5   	   -   5        $	��450��5   	   $	��400��6     � 
ResizeMode$  CanMinimize=�5   	      BackgroundColor#��[  5   	    J� SnapsToDevicePixels$
 True��5   	     TextFont#��[ 5   	    � WindowStyle$
 None=�5   	    � Title 5
   	   �� *Proj.FileName+ � 	Resources 5       �� DataType&    ProgressTracker.Model.LinearWork � RowDefinitions J� Opacity  SuccessColor � Value  TextLightColor	 ��Name
 �� Orientation  TextNormalColor ��Name  
SymbolFont � ToolTip �� Triggers �� Value �� Binding �� Path �� 
TargetName �� Property �� Value��%[  (��       5      *, +)7  7  7  7  7  7  �� 6
   "  6   .R�5      �� $	��Top=�6   ._�5      �  5      �� 5      �� 5      $��4 �6(   .+�5      �� $��1��6   
���   �$	 0.1Q�6=   � 5      $��1��6"   8��  
������  6/   �� *
Percentage+6w   � 5       $��12q�6   .+�5!      �� 8�� $��16(�6g   $��Center=�6u   ��6$   �� *Name+6u   �� 5#      $	 TextPercentage��6%   $��Right=�6=   $��Center=�6Y   $
 
Horizontal=�6t   .+�5$      �� 8�� $��16(�6q   ��6(   �� *
Percentage+6q   �� 5%      $��%��6(   8�� $��16(�6_   5&      �� 5(      $ TextCheckmark��6$   $��Right=�6;   $��Center=�6W   $��18(�6r   $��Medium"�6�   $	����6�   8�� 8�� $ 
Completed!��6�   5)      5*      5+       5-      �� 5.      $
 True��6A    6   �� $ 	Completed�.a�5/      �� $ TextPercentage��6    � y�$ Hidden=�6O   50      �� 52      $ False��6A    6   �� $ 	Completed�.a�53      �� $ TextCheckmark��6    � y�$ Hidden=�6N   54      56      57      .��59      ��   PrimaryColor#��[ 6   $��1q�69   ._�5:   
   �  5;      �� 5<      $��32 �6    �� 5=      $��8 �6    �� 5>      �� 5?      $
��Auto �6    .+�5B      ��   ForegroundColor#��[ 6   �� 5C      $��Center=�67   $��Medium"�6T   $��Center=�6i   $	��110��6�   #��[ 6�   ��6   �� *Proj.FileName+6�   �� 5D      -   5        
������ 5D   0   �� 5F      $
 
Horizontal=�6   $
��Left=�62   .+�5G      �� $��32��6   $	����6$   $��16(�67   #��[ 6E    � Cursor$
 Hand��6n     TransparentButtonStyle#��[ 6�   $ Open project��6�   ��6|   �� *CMDOpenProject+6�   �� 5H      $��32��6   $	����6$   $��16(�67   #��[ 6E   $
 Hand��6n   #��[ 6�   $ Create project��6�   ��6|   �� *CMDCreateProject+6�   �� 5I      $��32��6   $	����6$   $��16(�67   #��[ 6E   $
 Hand��6n   #��[ 6�   $
 Save��6�   ��6|   �� *	CMDSave+{�6�   �� *
HasChanges+6�   5J      �� 5L      $
 
Horizontal=�6   $��Right=�62   .+�5M      �� -   5        $��40��5M      $	����6$   #��[ 6H   #��[ 6r   �� 5N      -   5        $��40��5N      $	����6$   #��[ 6E   #��[ 6n   5O      �� 5Q      $��1��6   $��2��6%   $��Hello there!��66   $��Center=�6k   $��Center=�6�   $
��Bold"�6�   #��[ 6�   $��16(�6�   {�6J   �� *
HasProject+6�   R� 5S      $��2��6   $��1��6(   ��65   �� *Root.SubWork+��5T      �� 5U      $   ProgressTracker.Model.WorkNode"  6/    �� ItemsSource 6Q   �� *	SubWork+.R�5V      �� $	��kek��6$   5W      5Y      �� 5[      $��1��6    J� IsHitTestVisible$ False��6%   ��5\      �� 5]       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 0,1&�6;    �� Opacity$	 0.1Q�6J   .��5^      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5_      $ 	#00000000��6'   $ 1Q�69   5`      5b      �� 5d      $��3��6   #��[ 6"   ._�5e      �� $
 
Horizontal=�6   .+�5f      �� $��24��6   $��24��6(   $��0��64   $	����6B   $
��Left=�6U   #��[ 6p   #��[ 6�   $ Reload file��6  ��6�   �� *	CMDReload+{�6�   �� *
HasProject+6  �� 5g       	 TextDarkColor#��[	 6=   $��10(�6i   $��Center=�6w   $
��Left=�6�   $��4,0,0,0q�6�   $��Medium"�6�   ��6    �� *Proj.Status+6�   5h      5i      #   ProgressTracker.OverlayHolder  5k      #   ProgressTracker.OverlayHolder   LockAreaClick$! OverlayHolder_LockAreaClick��63   $��4��6"   63   5l      5m      5n      
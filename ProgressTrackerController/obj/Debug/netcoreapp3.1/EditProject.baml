   M S B A M L   `   `   `  ����N  JProgressTrackerView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProgressTrackerControllerProgressTrackerController  5   	   +    %ProgressTrackerController.EditProject   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProgressTrackerController     5   	     � Title$  Report Progress��5   	   $	��300��5	   	   $	��500��5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$ 
ToolWindow=�5   	    � WindowStartupLocation$ CenterScreen=�6"   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� .+�5      �� $��1��6   $��25��6#   $��5q�6/   �� 5      $��1��6   $��25��6#   $��5q�6/   5      �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5      �� $��Cancel��6   $��5q�6&   $��80��61   �� 5      $��Report��6   $��5q�6&   $��80��61   5      5!      5"      
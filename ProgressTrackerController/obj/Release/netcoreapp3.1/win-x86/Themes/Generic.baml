   M S B A M L   `   `   `  ���� N  JProgressTrackerView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProgressTrackerControllerProgressTrackerController  W0clr-namespace:ProgressTrackerController.Controls"ProgressTrackerController.Controls  U QSystem.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   PrimaryColor  �� Color  
ErrorColor  SuccessColor  WarningColor  ErrorColorDark  BackgroundColor  ForegroundColor  HighlightColor  TextNormalColor 	 TextDarkColor 
 TextLightColor  ScrollbarColor  ScrollbarHighlightColor  
SymbolFont  TextFont  	BoolToVis  SecondaryButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name � UseLayoutRounding J� Effect3   -System.Windows.Media.Effects.DropShadowEffect    
BlurRadius	    ShadowDepth
    	Direction    Color    Opacity    RenderingBias ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName  TransparentButtonStyle ��Name  PrimaryButtonStyle �� BasedOn J� Opacity5   /ProgressTrackerController.Controls.NumericInput � ColumnDefinitions � RowDefinitions ��Name ��Name  FlatListBoxItemBase K� IsItemsHost ��Name  ComboBoxToggleButton F�Name  ComboBoxTextBox �� 	ClickMode d� 	IsChecked  �� Path! �� Mode" �� RelativeSource# J� IsHitTestVisible$ �� SelectionBoxItem% �� SelectionBoxItemTemplate& �� 
IsReadOnly' �� 
IsReadOnly( �� IsDropDownOpen) � AllowsTransparency* � ActualWidth+ �� MaxDropDownHeight-  'System.Windows.Input.KeyboardNavigation,   DirectionalNavigation- P� 
SourceName. �� Triggers/ ��Name  MultilineTextBox  ScrollBarLineButton  ScrollBarPageButton  ScrollBarThumb  VerticalScrollBar0 ]�Name1 ]� DecreaseRepeatButton2 ]� Thumb3 ]� IncreaseRepeatButton  HorizontalScrollBar  ScrollViewerControlTemplate4 �Name5 ��Name6 �� CanContentScroll7 �� CanHorizontallyScroll8 �� CanVerticallyScroll9 ��Name4  .System.Windows.Automation.AutomationProperties:   AutomationId; � Cursor< �� ScrollableHeight= � Maximum> � Minimum*? �� #ComputedVerticalScrollBarVisibility@ �� ViewportHeightA �� ViewportSizeB � ValueC �� ScrollableWidthD �� Orientation,E �� %ComputedHorizontalScrollBarVisibilityF �� ViewportWidth�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     1local'clr-namespace:ProgressTrackerController  =Controls0clr-namespace:ProgressTrackerController.Controls  4sys,clr-namespace:System;assembly=System.Runtime  %_*  &	        &	      &	 *     &	 =     &	 R     &	 g     &	 z     &	 �     &	 �     &		 �     &	
 �     &	 �     &	 �     &	     &	 J    &	 \    &	 a    7  7  7 
 7   7   7  7  7  &	     7 
 7  7   7  &	     7  7   '�� �    7  '  �    7  7  7  7  '�� �	    7 	 7  7  &	 u
    7  7   '�� �    7  7  '��     7   7  '�� �    7 	 7  7   7 
 &	 �    7  7  7   7  7   &	     '�� O    7 
 7  7  7  7   '�� �    7 
 7   '�� X    7 
 7 
 7  7  7   7   7  &	 �    7 
 7 
 7  7  7   7   7  &	 o    7  7  7  7  7  7  7  &	 Z    &	 !    7  7  &	 5     7  7  7  7  7  7  7  &	 �!    7  7  7  7  7  7  7  '�� �#    7  7  '�� �$    &	 &%    �� $  	#FF0034FF���� $  	#FFFF162A���� $  #03fc52���� $  	#FFF84221���� $  	#FFB70C1B���� $  #191919���� $  #202020���� $  #303030���� $  #A4A4A4���� $  	#FF565656���� $  
WhiteSmoke���� $  #21252b���� $  	#FF2C3138��*�>:pack://application:,,,/Resources/Fonts/#remixicon Standart)�*�Segoe UI)��� �� " ��.���  �@�Cursor$
 Hand����  � ��$ 15(���  �@�UseLayoutRounding$
 True����  �@J�SnapsToDevicePixels$
 True����  � ��$ 24����  � �� �� " ��.R��� $ bd��8��  $��1q�8�� $��25��$
 True��    $ 10Q�$	 3Q�$	
 -90Q�$ Black��$	 0.1Q�$ Performance=�._��� $ MyContentPresenter��8�� #��z��$��Center=�$��Center=�$��Regular"�$��14(�$ False��$ False�� P�  �@J�IsMouseOver$
 True��. ��� $ bd��8   � ��P�  � ��$
 True��. ��� $ bd��8   � ��P�  � {�$ False��. ��� $ bd��8   � ���� $ bd��8   � ���� $ MyContentPresenter��8   � ���� " ��.���  � ��8   ��  � ��$ 15(���  �@�UseLayoutRounding$
 True����  �@J�SnapsToDevicePixels$
 True����  � ��$ 24����  � �� �� " ��.R��� $ Bd��
������ ._��� $ MyContentPresenter��#��z��$��Center=�$��Center=�$ False��$ False�� P�  �@J�IsMouseOver$
 True��. ��� $ Bd��8   � ��P�  � ��$
 True��. ��� $ Bd��8   � ��P�  � {�$ False��. ��� $ Bd�� � ��
 ���� �� 8   � ���� 8   " ��.���  �@�Cursor$
 Hand����  � �� �� " ��.R��� 8�� ._�� .+��� $	 lig��
�������$
 0.05Q�$y�Hidden=��� $ MyContentPresenter��#��z��$��Center=�$��Center=�$ False��$ False���� $	 dim��
���   �$	 0.2Q�$y�Hidden=� P�  �@J�IsMouseOver$
 True��. ��� $	 lig�� � y�$ Visible=�P�  � ��$
 True��. ��� $	 dim�� � y�$ Visible=��� $	 lig�� � y�$ Hidden=��� " ��8   �� "  .���  �@J�SnapsToDevicePixels$
 True����  �@�UseLayoutRounding$
 True����  � ��$ 32����  � ��$ 24����  � �� �� "  .R�� .+��  �� �� $��16 � �� �� .+��� $ MainTextBox��$��2���� $ IncrementButton��$��1��8��  $��0��$��12(�8�� $	������ $ DecrementButton��$��1��$��1��8�� $��0��$��12(�8�� $	������ " ��.���  � �� �� " ��.R��� $��0��$��2��$��0q�._��  �� $
��Auto ��� $��* �.+��� 8��  8�� $��13(�.���� $��Header��$
��True��$��Stretch=��� 8�� $��1���� $��1��$��10q��� " �����  � �� �� " ��.R��� $ Bd��#��z��._��� $��1�� P�  �@J�IsMouseOver$
 True��. ��� $ Bd��8    � ��P�  �@J�IsMouseOver$ False��. ��� $ Bd�� � ��
 ���� P�  �@��
IsSelected$
 True��. ��� $ Bd��8   � ���� " ��.���  � ��8   ��  � ��8  ��  � �� �� " ��.R��� ���� *
Background+.��$� $
 True���� " ��.���  � �� �� " ��.R��  �� $
��Auto ��� $��0 ��� $��* �.+��� $��1��8��  �� $
 True���� $��2��$��0q�8�� ._��� $��SelectedContent���� " ��.���  � ��$ 13(���  � �� �� " ��.R�� $	��110�� �� $
��Auto ��� $��3 �.+��� �� $
 Back��$��1���� $ CP��$��Header��$��Center=�$��Center=�$��5q� P�  �@��
IsSelected$ False��. ��� $
 Back�� � ��
 ���� �� 8    � ��P�  �@J�IsMouseOver$
 true��. ��� 8   � ��P�  �@��
IsSelected$
 True��. ��� $
 Back��8   � ���� 8   � ���� " d�.R��� $ B_main��8��  $��1q�8�� ._��  �� �� $��15 �.+�F� $ Arrow��$��1��
�������$��Center=�$��Center=�"����        � 	=  	= � z     	 P�  �@J�IsMouseOver$
 true��. ��� $ B_main��8   � ��P�  �@d�	IsChecked$
 trueY�. ��� $ B_main��8   � ���� $ B_main��8   � ���� $ Arrow�� � y�$ Hidden=��� " ��.R��� $ PART_ContentHost��$|�False��#��z���� " ��.���  �@�UseLayoutRounding$
 True����  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 True����  � ��$
 Auto=���  � ��$
 Auto=���  � ��$
 true����  � ��$	 120����  � ��$ 24����  � ��$ 13(���  � ��8   ��  � �� �� " ��.R�� .+�d� $��ToggleButton��8�� $��2��$|�false��$ Press=� �� $  IsDropDownOpen�$! TwoWay=�" �� *TemplatedParent+�� $��ContentSite��$# False��#��z$ #��z% #��z��$��5,3,5,3q�$��Center=�$
��Left=��� $ PART_EditableTextBox��8�� $
��Left=�$��Center=�$��5,3,5,3q�$
|�True�����	#FF3F3F3F
��� � �$y�Hidden=�#' z& ��Z� � $��Popup��$��Bottom=�#��z( $
) True��$
 True��$
 True��$|�False��$
��Fade=�.��� $��DropDown��$
 True��#��z* #��z+ .+��� $ DropDownBorder��8�� $��1q�8�� ._��� $��0q�$
 True��.���� $
 True��$, 	Contained=� P�  �@��HasItems$ false��. ��� $ DropDownBorder�� � ��$ 95��P�  �@��
IsGrouping$
 true��. ���  � ��$ false��P� $- Popup�� �@�AllowsTransparency$
 true��. ��� $ DropDownBorder�� �@��CornerRadius$ 0���� $ DropDownBorder�� � ��$ 0,2,0,0q�P�  �@��
IsEditable$
 true��. ���  � ��$ false���� $ PART_EditableTextBox�� � y�$ Visible=��� $ ContentSite�� � y�$ Hidden=�. �� " ��.���  �@J�SnapsToDevicePixels$ False����  �@�UseLayoutRounding$ False����  � ��8   ��  �@�OverridesDefaultStyle$
 true����  � �� �� " ��.R��� $��Border��$
 true��._��� $��3q� P�  �@��IsHighlighted$
 true��. ��� $ Border��8   � ��P�  � {�$ false��. ���  � ��
 ���� �� " ��.���  �@J�SnapsToDevicePixels$
 True����  �@�UseLayoutRounding$
 True����  �@�OverridesDefaultStyle$
 True����  �@ TabNavigation$
 None=���  �@�Cursor$ IBeam����  � ��8   ��  �@��
CaretBrush8  ��  � ��$ 24����  �@��AcceptsReturn$ False����  �@��TextWrapping$ NoWrap=���  � ��$ Center=���  � �� �� " ��.R��� $��Border��$��1q�8�� 8�� ._��� $/ PART_ContentHost�� P�  �@J�IsMouseOver$
 true��. ��� $ Border��8   � ��P�  �@��IsSelectionActive$
 True��. ��� $ Border��8   � ���� $ Border��8   � ���� " ��.���  �@J�SnapsToDevicePixels$
 True����  �@�UseLayoutRounding$
 True����  �@�OverridesDefaultStyle$
 True����  �@ TabNavigation$
 None=���  �@�Cursor$ IBeam����  � ��8   ��  �@��
CaretBrush8  ��  � ��$ 25����  �@��AcceptsReturn$
 True����  �@��TextWrapping$
 Wrap=���  � �� �� " ��.R��� $��Border��$��1q�8�� 8�� ._��� $/ PART_ContentHost�� P�  �@J�IsMouseOver$
 true��. ��� $ Border��8   � ��P�  �@��IsSelectionActive$
 True��. ��� $ Border��8   � ���� $ Border��8   � ���� " ��.���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true����  � |�$ false����  � �� �� " ��.R��� $ Border��8��  ._��� $ Symbol��$��18(�8�� 8�� $��Center=�$��Center=����� *	Content+" �� *TemplatedParent+ P�  �@J�IsMouseOver$
 True��. ��� $ Border��8   � ���� $ Symbol��8   � ��P�  � ��$
 True��. ��� $ Symbol��8   � ���� $ Border��8   � ���� " ��.���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true����  � ��$ false����  � |�$ false����  � �� �� " ��.R��� 
������ �� " n�.���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true����  � ��$ false����  � |�$ false����  � �� �� " n�.R��� $
 Back��8��   P�  �@J�IsMouseOver$
 true��. ��� $
 Back��8   � ���� " ��.R��  �� $��16���� $��1 ��� $��0.00001* ��� $��1 ��� $��16��.+��� $��5��
��� ����� 8��  $��ScrollBar.LineUpCommand��$	������ $��1��8�� ]� $0 
PART_Track��$��2��$
��true��1 �� 8�� $��ScrollBar.PageUpCommand��2 n� 8�� 
�������3 �� 8�� $��ScrollBar.PageDownCommand���� $��3��8�� �� $��4��8�� $��ScrollBar.LineDownCommand��$	������ " ��.R��  �� $��16���� $��1 ��� $��0.00001* ��� $��1 ��� $��16��.+��� $��5��
��� ����� 8��  $��ScrollBar.LineLeftCommand��$	������ $��1��8�� ]� $0 
PART_Track��$��2��$��False��1 �� 8�� $��ScrollBar.PageLeftCommand��2 n� 8�� 
�������3 �� 8�� $ ��ScrollBar.PageRightCommand���� $��3��8�� �� $��4��8�� $ ��ScrollBar.LineRightCommand��$	������ " ��.���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true��. P�  �@��Orientation$ 
Horizontal=�. ���  � ��$
 Auto����  � ��$ 16����  � ��8   P�  �@��Orientation$ Vertical=�. ���  � ��$ 16����  � ��$
 Auto����  � ��8  �� " ��. P�  � {�$ false��. ���  � ��# � ��.���  � ��# �  �� " ��.R�� $
4 Grid��#��z�� �� $��* ��� $
��Auto � �� $��* ��� $
��Auto �.+��� $!5 PART_ScrollContentPresenter��#6 z��$7 False��$8 False��#��z��#��z��$��0��#��z��$��0���� $9 PART_VerticalScrollBar��$: VerticalScrollBar��$; Arrow��$��1��#= z< $> 0Q�$��0��#y�z? #A z@ B �� *VerticalOffset+$! OneWay=�" �� *TemplatedParent+�� $9 PART_HorizontalScrollBar��$: HorizontalScrollBar��$; Arrow��$��0��#= zC $> 0Q�$D 
Horizontal=�$��1��#y�zE #A zF B �� *HorizontalOffset+$! OneWay=�" �� *TemplatedParent+
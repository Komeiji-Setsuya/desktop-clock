   M S B A M L   `   `   `  ����G  CDesktopClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DesktopClock.CustomDesktopClock.Custom  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DefaultMainMenuComboBoxItem  �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� IsHitTestVisible ��Name �� Triggers P� Property	 P� Value
 �� 
TargetName  ComboToggleButton �Name ��Name  EditableTextBoxStyle ��Name �� Triggers  DefaultMainMenuComboBox ��Name �� 
CaretBrush �� SelectionBrush �� SelectionTextBrush �� Text d�Name d� 	IsChecked �� Mode �� RelativeSource �Name � AllowsTransparency ��Name-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      +local!clr-namespace:DesktopClock.Custom  5      %�  &	        &	 �    &	 �    &	 �	    7   �� 5      "  ��60   .�5   
   ��  � ��$ Stretch=�67   �� 5   
    � ��$ Center=�65   �� 5
   
    � ��$ 0q�6,   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � #��z��6   $��0,0.5q�6E   .+�5      �� $ ItemBackground��6!   $ False��5   !   #��z��5   !   #��z��5   !   #��z��5   !   �� 5      $ contentPresenter��6+   #��z��5   +   #��z��5   +   #��z��6j   5       5      P� 5       �@��
IsSelected$
	 True��68   . �5      �� $
 ItemBackground��6%    � �� �	#7F0000006W   5      P� 5       �@J�IsMouseOver$
	 True��69   . �5      �� $
 ItemBackground��6%    � �� �	#3F0000006W   5      5       5"      5#      �� 5%      "  d�6   .�5&   
   ��  � �� �	#3FFFFFFF6'   �� 5'   
    � �� 5(      �� 5)      " d�6"   .R�5*      � $
 Grid��6   .+�5+      �� $ Bg��6K   #��z��6!   6K   �� 5,      $
 Icon��6$   $
��🔻��62   #��z��5-   $   5.       50      P� 51       �@J�IsMouseOver$
	 True��69   . �52      ��  � �� �	#BFFFFFFF6;   �� 53      $
 Bg��68    �@J�Opacity$
 0.55Q�6H   54      P� 55       � ��$
	 True��67   . �56      ��  � �� �	#7FFFFFFF6;   �� 57      $
 Bg��68    �@J�Opacity$	 0.6Q�6H   58      P� 59       �@d�	IsChecked$
	 TrueY�67   . �5:      ��  � �� �	#7FFFFFFF6;   �� 5;      $
 Bg��68    �@J�Opacity$	 0.6Q�6H   5<      P� 5=       � {�$	 false��67   . �5>      �� $

 Grid��6D    �@J�Opacity$	 0.5Q�68   6D   5?      5A      5C      5D      �� 5G      "  ��6   .�5J   
   ��  � ��$ 1q�6,   �� 5K   
    � ��
 ���� 6'   �� 5L   
    � �� �	#AAFFFFFF6'   �� 5M   
    �@��SelectionBrush �	#7FFFFFFF6+   �� 5N   
    �@��SelectionTextBrush
 �����6/   �� 5O   
    � |�$
 True��6&   �� 5P   
    �@��
CaretBrush �	#AAFFFFFF6'   �� 5Q   
    � ��$ Center=�6.   �� 5R   
    � �� 5S      �� 5T      " ��6"   .R�5U      �� $��Border��6   $��1q�5V      ���	#3FFFFFFF
������ ._�5X      �� $ PART_ContentHost��62   $��0q�6'   62   5Y       5Z      P� 5[       �@J�IsMouseOver$
	 True��69   . �5\      �� $
 Border��6N    � �� �	#AAFFFFFF5]      5_      5a       5b   
   P� 5c       � {�$	 False��6+   . �5d      ��  �@J�Opacity$	 0.5Q�6,   6:   5e      5g      �� 5i      "  ��6,   .�5j   
   ��  � ��
 ���� 6'   �� 5k   
    � �� �	#AAFFFFFF6'   �� 5l   
    � ��$ 20��6#   �� 5m   
    � ��$	 200��6"   �� 5n   
    � ��$ Stretch=�67   �� 5o   
    � ��$ Center=�65   �� 5p   
    � ��$ 1q�6,   �� 5q   
    � �� �	#AAFFFFFF6(   �� 5r   
    � ��8   6/   �� 5s   
    �@��
IsReadOnly$
 True��6'   �� 5t   
    �@��
IsEditable$
 True��6'   �� 5u   
    � ��$ False��6:   �� 5v   
    � ��$ Hidden=�6E   �� 5w   
    � �� 5x      �� 5y      " ��6"   .R�5z      � $ 	PART_Root��6   .+�5|      �� $ PART_EditableTextBox��6"   #��z��6@   
������ #��z��5}   ;    �	#AAFFFFFF �	#7FFFFFFF
 �����#��z��5   "   #��z��6l   #��z��5�   "   #��z 5�   "   #��z��6@   #���  6f   d� 5�      $ PART_DropDownToggle��6'   $��False��6D   $
��🔻��5�   '   #��z��64   
������ $��0q�5�   '   #��z��6;   $��Right=�5�   '   #���  6C    5�   '   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+5�   C   � 5�      $ 
PART_Popup��6    $
 True��64   $|�False��6N   #��� .�5�       $��Bottom=�6y   ��5�       �� *IsDropDownOpen+ �� *TemplatedParent+.��5�      � ��6#   �� *ActualWidth+ �� *TemplatedParent+��5�   #   �� *MaxDropDownHeight+ �� *TemplatedParent+.+�5�   "   �� $ PopupBorder��6)   #��z��6>   $��Stretch=�6r   $
��Auto��5�   )   #��z��67   ���	#010000005�   #   �� 5�   "   $ DropDownScrollViewer��6/   $��0q�6M   .��5�   &   �� $ ItemsPresenter��65   $ 	Contained=�6M   5�   #   5�      5�      5�      5�      5�      5�      5�      
   M S B A M L   `   `   `  ����G  CDesktopClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DesktopClock.CustomDesktopClock.Custom  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   CustomMenuItemStyle  �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� Opacity � ColumnDefinitions ��Name z� SharedSizeGroup	 ��Name
 ��Name m� InputGestureText �Name � AllowsTransparency � VerticalOffset �� RelativeSource �� CornerRadius �Name � IsSharedSizeScope K� IsItemsHost-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation �� Triggers P� Property P� Value �� 
TargetName  DefaultMenuItemStyle �� BasedOn �� AncestorType �� Mode  DefaultContextMenuStyle �� Color�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      +local!clr-namespace:DesktopClock.Custom  5      %  &	        &	 �    7   &	 r    'm� �    7  '�� �    7  �� 5      "  m�6(   .�5   
   ��  � �� �	#7FFFFFFF6(   �� 5   
    � ��$ 1q�6,   �� 5   
    � �� �	#540000006'   �� 5	   
    � �� �	#AAFFFFFF6'   �� 5
   
    � ��$ 12(�6%   �� 5   
    � ��$ 28��6#   �� 5   
    � ��$
 Auto��6"   �� 5   
    � ��$ 1q�6#   �� 5   
    � �� 5      �� 5      " m�6"   .R�5      �� $ border��6   
������ #��z��6G   $ 1Q�6i   ._�5      � $��Center=�6    #��z��6;    5      �� 5   "   $ icon_col��63   $��0��6E   $��* �6R   �� 5   "   $
��Auto �63   $ MenuTextColumnGroup��6@   �� 5   "   $
��Auto �63   $ MenuItemIGTColumnGroup��6@   �� 5   "   $ 	arrow_col��6>   $��16 �63   $ MenumItemArrow��6Q   .+�5      �� $	 	PART_Icon��6(   $ 0Q�6;   #��z��6G   $��5,1,1,1q�6q   ${�False��6�   �� 5!      $
 	txtHeader��6?   $��1��6/   $��3,1,5,1q�6R   $��90��6c   $
��True��5"   +   $��Center=�6F   $��Header��6a   �� 5$      $	 IGTHost��6I   $��2��6(   $��3,1,3,1q�68   #��z 6Z   #��z��5%   (   $��Center=�5&   (   $y�Visible=�6C   #��z��6X   �� 5(      $	 
PART_Arrow��6(   $��3��6<   $	��▶��6L   #��z��6U   $��14(�5)   (   � 5+      $ SubMenuPopup��6$   $
 true��6:   $��Bottom=�5,   )   $|�false��6=   $ 0��6O   #��� -�5-   $   ��5+   T   �� *IsSubmenuOpen+ �� *TemplatedParent+.��5.   "   �� #��z��6)   $ 0��6T   $��5q�6e   #��z��5/   1   #��z��6]   ._�50   &   � $ SubMenu��6+   $
 True��6<   .+�51   *   �� $��0q�65   $
 True��6@   $ Cycle=�6S   52   '   53   #   54      55      56       58      P� 5:       �@m�Role$ TopLevelHeader=�62   . �5;      �� $ 
PART_Arrow��6M    � y�$ 	Collapsed=�6;   6M   �� 5<      $ IGTHost��6M    � y�$ 	Collapsed=�6;   6M   �� 5=      $ 	txtHeader��6G    � ��$ 1,1,6,1q�67   6G   �� 5>      $ 	txtHeader��6D    � ��$ 10��69   6D   �� 5?      $ 	arrow_col��6@    � ��$ 0 �66   6@   5@      P� 5B       �@m�Role$ TopLevelItem=�62   . �5C      �� $ 
PART_Arrow��6M    � y�$ 	Collapsed=�6;   6M   �� 5D      $ IGTHost��6M    � y�$ 	Collapsed=�6;   6M   �� 5E      $ 	txtHeader��6G    � ��$ 1,1,6,1q�67   6G   �� 5F      $ 	txtHeader��6D    � ��$ 10��69   6D   �� 5G      $ 	arrow_col��6@    � ��$ 0 �66   6@   5H      P� 5J       �@m�Role$ SubmenuHeader=�62   . �5K      �� $ 
PART_Arrow��6K    � y�$ Visible=�6;   6K   �� 5L      $ SubMenuPopup��6H    � ��$ Right=�6:   6H   5M      P� 5O       �@m�Role$ SubMenuItem=�62   . �5P      �� $ 
PART_Arrow��6M    � y�$ 	Collapsed=�6;   6M   5Q      P� 5S       �@m�	IsChecked$
 True��67   . �5T      �� $ 	PART_Icon��6%    � ��$	 √��6<   6X   �� 5U      $ 	PART_Icon��6%    � ��$ 18(�6<   6]   �� 5V      $ 	PART_Icon��6%    � �� �	#AAFFFFFF6f   �� 5W      $ 	PART_Icon��6%    � {�$ False��6Q   �� 5X      $ 	PART_Icon��6%    �@J�Opacity$ 0Q�6O   5Y      P� 5Z       � {�$ False��67   . �5[      �� $ border��6%    �@J�Opacity$	 0.5Q�69   6Z   5\      P� 5^       �@m�IsHighlighted$
 true��6;   . �5_      �� $ border��6;    � �� �	#540000006c   �� 5`       � �� �	#AAFFFFFF6O   5a      P� 5c       �@m�	IsPressed$
 true��67   . �5d      �� $ border��6;    � �� �	#3F0000006c   �� 5e       � �� �	#AAFFFFFF6O   5f      P� 5h       �@m�IsSubmenuOpen$
 true��6;   . �5i      �� $ 
PART_Arrow��6%    � �� �	#AAFFFFFF6g   5j      5l      5n      5o      �� 5r      "  m�6)   8   .�5s   
   ��  � �� 5t      �� 5u      .R�5v      �� $	 	txtHeader��6    $��Stretch=�5w       $��3,1,5,1q�6>   $��Center=�5x   �   ��5v   3   �� *
FontSize+ �� " m�$ FindAncestor=���5x       �� *Header+ �� " m�$ FindAncestor=���5y       �� *
Foreground+ �� " m�$ FindAncestor=�5z      5|      5}      �� 5�      "  ��6,   .�5�   
   ��  � �� 5�      �� 5�      " ��6"   .R�5�      �� $ Border��6   ���	#54000000$��1q�5�      ��5�      �� 5�      $ 	#3FFFFFFF��6.   ._�5�      �� $
 True��6%   $ Cycle=�5�   %   5�      5�      5�      5�      �� 5�      "  m�6   8   6+   �� 5�      "  ��6   8   6.   5�      
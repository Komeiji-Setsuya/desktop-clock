   M S B A M L   `   `   `  ����G  CDesktopClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DesktopClock.CustomDesktopClock.Custom  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   CustomButton_Template  �� 
TargetType&    DesktopClock.Custom.CustomButton ��Name �� RelativeSource �� Mode �� Path �� CornerRadius �� Orientation ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName �� Value �� Property �� 
TargetType  MainMenuButtonStyle  BoxRadioButton �Name�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      +local!clr-namespace:DesktopClock.Custom  5      %
  &	        '   q    7   &	 �    7   &	 >
    �� 5      "    64   .R�5   
   �� $ border��6   ��5      ��  �� $ TemplatedParent=�$ 
Background���5      ��  �� $ TemplatedParent=�$ Height���5	      ��  �� $ TemplatedParent=�$ Width� 5
      ��  �� $ TemplatedParent=�$ CornerRadius�._�5      �� $ 
Horizontal=�6   $��Center=�5      #��z��5      #��z��5      .+�5      �� $
 text��6   $��Center=�5      ��5      ��  �� $ TemplatedParent=�$ Content���5      ��  �� $ TemplatedParent=�$ FontSize���5      ��  �� $ TemplatedParent=�$ 
Foreground�5      5      5       5   
   P� 5      	 �@J�IsMouseOver$

 True��6-   . �5      �� $ border��6�    6/   ��  �� $ TemplatedParent=�$ MouseOverBackground� � ��6�   �� 5      $
 text��6�    6/   ��  �� $ TemplatedParent=�$ MouseOverForeground� � ��6�   5      P� 5      	 � ��$

 True��6+   . �5       �� $ border��6�    6/   ��  �� $ TemplatedParent=�$ PressedBackground� � ��6�   �� 5!      $
 text��6�    6/   ��  �� $ TemplatedParent=�$ PressedForeground� � ��6�   5"      P� 5#      	 � {�$
 False��6+   . �5$      �� $ border��68    �@J�Opacity$	 0.5Q�6,   68   5%      5'      �� 5+      "   6   .�5,   
   ��  � ��8   6%   �� 5-   
    � ��
 �����6'   �� 5.   
    � ��
 �   �6'   �� 5/   
    �@  MouseOverBackground
 �����60   �� 50   
    �@  MouseOverForeground
 �   �60   �� 51   
    �@  PressedBackground
 �����6.   �� 52   
    �@  PressedForeground
 �   �6.   �� 53   
    � ��$ Center=�67   �� 54   
    � ��$	 100��6"   �� 55   
    � ��$ 30��6#   �� 56   
    �@  CornerRadius$ 0��6)   �� 57   
    � ��$ 3,1,3,1q�6$   �� 58   
    � ��$ CustomButton��6$   59      �� 5<      "   6(   .�5=   
   ��  � ��8   6%   �� 5>   
    � ��
 ���� 6'   �� 5?   
    � �� �	#AAFFFFFF6'   �� 5@   
    �@  MouseOverBackground �	#7F00000060   �� 5A   
    �@  MouseOverForeground �	#AAFFFFFF60   �� 5B   
    �@  PressedBackground �	#3F0000006.   �� 5C   
    �@  PressedForeground �	#AAFFFFFF6.   �� 5D   
    � ��$ Center=�67   �� 5E   
    � ��$	 100��6"   �� 5F   
    � ��$ 30��6#   �� 5G   
    �@  CornerRadius$ 0��6)   �� 5H   
    � ��$ CustomButton��6$   5I      �� 5L      " 	�6#   .�5M   
   ��  � �� �	#540000006;   �� 5N   
    � �� �	#7FFFFFFF6;   �� 5O   
    � ��$ 3 2 3 2q�6$   66   �� 5P   
    � ��$ 12(�6%   62   �� 5Q   
    � ��$ 1q�6,   68   �� 5R   
    � ��$
 auto��6#   62   �� 5S   
    � ��
 ���� 6(   �� 5T   
    � �� 5U      �� 5V      "  	�6"   .R�5W      � $
 grid��6   $��Center=�6)   .+�5X      �� #��z��6!   #��z��6U   #��z��6�   $��Center=�6�   #��z��5Y   !   #��z��6K   ._�5Z      �� $��Center=�6/   $��Center=�6J   #��z��6g   5[      5\       5^      P� 5_      	 �@d�	IsChecked$

 trueY�67   . �5`      ��  � �� �	#AAFFFFFF6P   �� 5a       � �� �	#540000006;   5b      P� 5c      	 �@J�IsMouseOver$

 true��69   . �5d      ��  � �� �	#7FFFFFFF6P   �� 5e       � �� �	#3F0000006;   5f      P� 5g      	 �@J�IsMouseCaptured$

 True��6=   . �5h      ��  � �� �	#7F0000006;   5i      P� 5j      	 � {�$
 False��67   . �5k      �� $
 grid��6D    �@J�Opacity$	 0.5Q�68   6Y   5l      5n      5p      5q      5t      
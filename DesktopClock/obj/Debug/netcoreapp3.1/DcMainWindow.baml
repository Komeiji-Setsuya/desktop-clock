   M S B A M L   `   `   `  ����G  CDesktopClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DesktopClockDesktopClock  5      9!clr-namespace:DesktopClock.CustomDesktopClock.Custom  5      C&clr-namespace:DesktopClock.MiscClassesDesktopClock.MiscClasses  5      E'clr-namespace:DesktopClock.OtherWindowsDesktopClock.OtherWindows  5	          DesktopClock.DcMainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ,localclr-namespace:DesktopClock     5      0cb!clr-namespace:DesktopClock.Custom     5      5vc&clr-namespace:DesktopClock.MiscClasses     5      6ow'clr-namespace:DesktopClock.OtherWindows     5	      -   5          �Name$  dcMainWindow��5       � Title$ DcMainWindow��6	    � WindowStyle$
 None=�5   	   ���	#00000000 � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��Center=�5   	   $��Center=�6&    � 
ResizeMode$ NoResize=�5   	    � ShowInTaskbar$ False��6    � SizeToContent$ WidthAndHeight=�5   	   ��5       Z�  � 	Resources 5      =  7DesktopClock.MiscClasses.GetDcMainGridHeightToThisWidth "  getDcMainGridHeightToThisWidth?  9DesktopClock.MiscClasses.GetDcMainGridWidthToTimeFontSize $  getDcMainGridWidthToTimeFontSize.  (DesktopClock.MiscClasses.GetDateFontSize  getDateFontSize<  6DesktopClock.MiscClasses.GetDateFontSizeToWeekFontSize ! getDateFontSizeToWeekFontSize:  4DesktopClock.MiscClasses.GetDateFontSizeToWeekMargin  getDateFontSizeToWeekMargin��%�   &	        &	      &	 &     &	 9     &	 L       5   
   6,     5   
   6.     5   
   6     5   
   6+     5   
   6)   5      .��5      � -   5        	 �Name$	 
DcMainGrid��5      $y�Visible=�6   $
|�True��64   $	��180��5      ��5      �� *Height+
 �� 	Converter#
 [   �� ElementName$ 
DcMainGrid�� � RowDefinitions 5   
   �� 5       $��5* �6   �� 5!      $��3* �6   �� 5"      $��4* �6   .+�5$   
   �� -   5         ��Name$ FontBackground��5$      ���	#00000000$
��Left=�5%      $	��Top=�5&      $��1q�5'        ContexrMenu � ContextMenu# [ 5(      $��3��6<   ��5%   ,   �� *Height+$ 
DcMainGrid����5&   )   �� *Width+$ 
DcMainGrid�� �� CornerRadius 5)      �� *CornerRadius+$ MainBackground���� 5*   
   -   5        $
��Time��5*      $��00:00:00��5+      $��Center=�5,      $	��Top=�5-      
�������$��Center=�50      $��Center=�62   $��5,0,5,0q�6V   ��5/      �� *Width+#
 [ $ 
DcMainGrid��50   V   �� 51   
   -   5        $
��Date��51      $��0000年00月00日��52      $��Center=�53      $	��Top=�54      $��Center=�57      $��Center=�62   $��1��6V   $��5,0,5,0q�6c   ��55      �� *
Foreground+$
 Time����56      �� *
FontSize+#
 [ $
 Time����58      �� *
FontFamily+$
 Time���� 59   
   -   5        $
��Week��59      $��	星期几��5:      $��Center=�5;      $	��Top=�5<      $��3��5?      $y�Visible=�5@      $��5,0,5,0q�6%   ��5=      �� *
FontSize+#
 [ $
 Date����5>      �� *
Foreground+$
 Time����5?      �� *
FontSize+#
 [ $
 Date����5A      �� *
FontFamily+$
 Time���� 5B   
   -   5        $ MainBackground��5B      ���	#01FFFFFF���	#01000000$
��Left=�5D      $	��Top=�5E      $��1q�5F      # [ 5H      $��3��6�   ��5D   ,   �� *Height+$ 
DcMainGrid����5E   )   �� *Width+$ 
DcMainGrid��._�5I      � .+�5J      &   DesktopClock.Custom.CustomButton  -   5          Name$ 
LockButton��5J   "   &    DesktopClock.Custom.CustomButton   Click$ LockButton_Click��5Q   1   $
��🔒��5K      $��25��5L      $��25��6%   $��Right=�5M      $	��Top=�66   ���	#01000000���	#7FFFFFFF   MouseOverBackground �	#3F000000   MouseOverForeground
 �����   PressedBackground �	#3F000000   PressedForeground �	#7FFFFFFF   CornerRadius$ 3,3,3,3��5Q       � ToolTip$ 锁定��5R       ^� InitialShowDelay$
 2000��6'    ^� ShowDuration$
 5000��6N   �� 5S      -	   5        $ OptionsContent��5S      $��25��5T      $��0��6#   ���	#7F000000$��0,0,0,10q�5V      $ 5��5W      $
��Left=�5X      $��Bottom=�62   ._�5Y      � $	��100��6   .+�5Z        -
   5        $ OptionsOpenMainMenu��5Z   *   $ OptionsOpenMainMenu_Click��5_   =     MainMenuButtonStyle#���  5[   *   $��设置��5\   *   $��25��5]   *   $��35��66   $��10(�5^   *   $��	25,0,40,0q�5_   *   6=     5`      -   5        $ OptionsShutdown��5`   *   $ OptionsShutdown_Click��5d   J   #���  5a   *   $��关闭��5b   *   $��25��5c   *   $��35��66   $��10(�5d   *   $��60,0,5,0q�68   6J   5f      5g        5h      -   5        $ Options��5h   "   $ Options_Click��5r      $	��⚙��5i      $��25��5j      $��25��6%   $��0,0,0,10q�5k      $
��Left=�5l      $��Bottom=�65   ���	#01000000���	#3FFFFFFF �	#01000000 �	#7FFFFFFF �	#01000000 �	#3FFFFFFF$ 16,16,16,16��5p       J� RenderTransformOrigin$ 0.5,0.5&�5q      $ 设置��5s      $
 2000��6'   $
 5000��6N   z�5t      �� 5u      -   5        OptionsRotateTransform��5u   *   5w      5x      5y      5z      5{      
   M S B A M L   `   `   `  ���� G  CDesktopClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DesktopClockDesktopClock  9!clr-namespace:DesktopClock.CustomDesktopClock.Custom      DesktopClock.DcMainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:DesktopClock     0cb!clr-namespace:DesktopClock.Custom     -     �Name$  dcMainWindow�� � Title$ DcMainWindow�� � WindowStyle$
 None=�$y�Visible=����	#00000000 � AllowsTransparency$
 True�� � WindowStartupLocation$ CenterScreen=�$��Center=�$��Center=�$|�False�� � 
ResizeMode$ NoResize=� � WindowState$ Normal=� � ShowInTaskbar$ False�� � SizeToContent$ WidthAndHeight=�$��False����Z� .��� $y�Visible=�$
|�True��$	��150��$	��250��.+��� -   $
��Time��$��00:00:00��$��Center=�$��Center=�
�������$��50(�$��Center=�$��Center=�$��0,0,0,50q��� -   $
��Date��$��0000年00月00日��$��Center=�$��Center=�
�������$��25(�$��Center=�$��Center=�$��0,60,0,0q��� -   	 ��Name$	 MainBackground�����	#01FFFFFF���	#01000000$��Center=�$	��150��$��Center=�$	��250��$��1q�   ContexrMenu
 � ContextMenu#
 [  ._�� .+�&   DesktopClock.Custom.CustomButton  -     Name$ 
LockButton��&    DesktopClock.Custom.CustomButton   Click$ LockButton_Click��$
��🔒��$��25��$��25��$��	0,10,10,0q�$��Right=�$	��Top=����	#01000000���	#7FFFFFFF   MouseOverBackground �	#3F000000   MouseOverForeground
 �����   PressedBackground �	#3F000000   PressedForeground �	#7FFFFFFF   CornerRadius$ 3,3,3,3�� � ToolTip$ 锁定�� ^� InitialShowDelay$
 2000�� ^� ShowDuration$
 5000���� -   $	 OptionsContent��$��25��$��0�����	#19000000$��10,113,0,10q� �� CornerRadius$ 5��$
��Left=�._�� .+�  -   $ OptionsOpenMainMenu��$ OptionsOpenMainMenu_Click��  MainMenuButtonStyle#���  $��设置��$��25��$��35��$��10(�$��	25,0,40,0q�  -   $ OptionsShutdown��$ OptionsShutdown_Click��#���  $��关闭��$��25��$��35��$��10(�$��60,0,5,0q�  -	   $ Options��$ Options_Click��$	��⚙��$��25��$��25��$��	10,0,0,10q�$
��Left=�$��Bottom=����	#01000000���	#3FFFFFFF �	#01000000 �	#7FFFFFFF �	#01000000 �	#3FFFFFFF$ 16,16,16,16�� J� RenderTransformOrigin$ 0.5,0.5&�$ 设置��$
 2000��$
 5000��z��� -
   OptionsRotateTransform��
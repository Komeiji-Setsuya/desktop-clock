   M S B A M L   `   `   `  ����G  CDesktopClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:DesktopClock.OtherWindowsDesktopClock.OtherWindows  5   	   9!clr-namespace:DesktopClock.CustomDesktopClock.Custom  5   	   *    $DesktopClock.OtherWindows.TestWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:DesktopClock.OtherWindows     5   	   4Custom!clr-namespace:DesktopClock.Custom     5   	     � Title$  
TestWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
         Storyboard1 �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�   &	        �� 5   
   .��5      U� $ border��6,   $ (FrameworkElement.Width)�6K   .\�5        $ 00:00:00��6'   $ 0Q�6:     5      $ 00:00:05��6'   $	 300Q�6:   5      5      5      .��5      � .+�5   
   �� .+�5      �� $	��213��6    �� Left$	 407��6(   
 �� Top$ 56��6:   $	��108��6J   .��5      � $	��500��6   5      5      �� 5   
   .+�5      �� 
����  �$��5��6!   	 �� X1$ 10��65   		 �� Y1$	 10��6=   	
 �� X2$	
 100��6E   	 �� Y2$ 10��6N   F� 5      
����  �$��5��6!   ��5      �� 5       �� 
StartPoint$ 10,20&�6#    �� EndPoint$ 100,20&�66   5      �� 5       
����  �$��30��6&   $��20��61   $ 30��6=   $ 10��6M   F� 5!      
����  ���5"      �� 5#       �� Rect$ 50,30,30,20�6(   5%      A� 5&      
����  �
���OO/�$��20��69   $��20��6D   $ 60��6P   $ 10��6`   F� 5'      
����  �
���������5(      @� 5)       @� RadiusX$ 10Q�6&    @� RadiusY$ 10Q�63    @� Center$ 60,70&�6@   5+      F� 5,      
���   �$��0��6"   
����  �$ 90��6B   $ 10��6R   "�������     �    ��� р����� 	6c   �� 5-      $	��161��6   $ 193.84��6(   $ 90��6=   $��98��6M   �� 5.      $	 150��6   $ 20��6&   .+�5/      F� $
��Auto��6   $
��Auto��6$   
�������"����    @KL � ��    � ��@KL 	50      51      �� 52      -   5         ��Name$ TestComboBox��52      $��20��6-   $	 549��69   $ 61��6K   $	��200��6[    �� 
IsReadOnly$
 True��6�    �� 
IsEditable$
 True��6�     DefaultMainMenuComboBox#���  6�   53      &   DesktopClock.Custom.CustomButton  54   
   -   5          Name$ 
TestButton��54      &    DesktopClock.Custom.CustomButton   Click$ CustomButton_Click��6x   $
��Auto��62   $
��Auto��6@   $��click me��6M   $��469,284,207,69q�6`   6x   �� 55   
   -   5         ��Name$ border��55      $��1q�6!   
���   �$��94,264,400,55q�6I   
���   �$	��300��6s   $	��100��6   $
��Left=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ._�56      � $	��300��6   $	��100��6   .+�57        $
��Left=�6&   $��98��6A   $��66,0,0,0q�6M   $��Center=�6_   $��86��6z     58      $
��Left=�6&   $��98��6A   $��	176,0,0,0q�6M   $��Center=�6`   $��96��6{   59      5:      5;      5<      
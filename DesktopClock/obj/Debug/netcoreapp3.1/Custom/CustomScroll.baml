   M S B A M L   `   `   `  ����G  CDesktopClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DesktopClock.CustomDesktopClock.Custom  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBarSize  ScrollBarButton  �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� TextAlignment �� Triggers P� Property P� Value	 �� 
TargetName  ScrollBarTrackButton  ThumbTemplate
 ��Name �� CornerRadius J� SnapsToDevicePixels  HorizontalScrollBar �Name � ColumnDefinitions J� Opacity ��Name �� Interval ]�Name ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  VerticalScrollBar � RowDefinitions  DefaultScrollBar �� Triggers  DefaultScrollViewer ��Name ��Name �� CanContentScroll �� CanHorizontallyScroll �� CanVerticallyScroll ��Name4   .System.Windows.Automation.AutomationProperties    AutomationId �� ViewportHeight  �� ViewportSize! � Cursor" �� ScrollableHeight# � Maximum$ � Minimum*% �� #ComputedVerticalScrollBarVisibility& � Value' �� Mode( �� RelativeSource) �� ScrollableWidth* �� Orientation,+ �� %ComputedHorizontalScrollBarVisibility, �� ViewportWidth- �� BasedOn�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      +local!clr-namespace:DesktopClock.Custom  5      .sys&clr-namespace:System;assembly=mscorlib  5      %�  &	        &	      &	 �    &	 t    &	 4    7  7  7  &	 s    7  7  7  &	 �    7  7   7  7   &	 l    '�� �    7  '�� �    7  X�5      12Q�6+   �� 5      "  ��6$   .�5   
   ��  � ��
 ���� 6'   �� 5	   
    � �� �	#3FFFFFFF6'   �� 5
   
    � ��$ Center=�6.   �� 5   
    � ��$ Center=�60   �� 5   
    � ��$
 auto��6"   �� 5   
    � ��$
 auto��6#   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $ ScrollBarButtonText��6    $��12(�5       ���	#3FFFFFFF$ Center=�5       $��Center=�5       $��Center=�6=   $
��🔹��5       $��1q�5        5      P� 5       �@J�IsMouseOver$
 True��69   . �5      �� $	 ScrollBarButtonText��6M    � �� �	#7FFFFFFF5      P� 5       � ��$
 True��67   . �5      �� $	 ScrollBarButtonText��6M    � �� �	#3FFFFFFF5      P� 5       � {�$ false��67   . �5       �� $	 ScrollBarButtonText��6D    �@J�Opacity$	 0.5Q�68   6D   5!      5#      5%      5&      �� 5)      "  ��6)   .�5*   
   ��  � ��
 ���� 6'   �� 5+   
    � �� 5,      �� 5-      " ��6"   .R�5.      �� 
������ 6   5/      51      52      �� 55      " n�6,   .R�56   
   � .+�57      �� $
 ScrollBarBackground��6   $ 4��63   $��2q�6D   $
 True��6O   ���	#3FFFFFFF6j   58       59   
   P� 5:       �@J�IsMouseOver$
 True��6-   . �5;      �� $	 ScrollBarBackground��6A    � �� �	#7FFFFFFF5<      P� 5=       � {�$ False��6+   . �5>      �� $	 ScrollBarBackground��68    �@J�Opacity$	 0.5Q�6,   68   5?      5A      �� 5D      " ��62   .R�5E   
   � $ HorizontalRoot��6   #��z��6'    5F      �� 5G      $
��Auto �6#   �� 5H      $��* �6#   �� 5I      $
��Auto �6#   .+�5L      �� $(
 "HorizontalScrollBarBackgroundInner��6   $��1��6A   $��0q�6Q   $
 True��6\   $	 0.3Q�6w   $ 6��6�   ���	#3F0000006�   �� 5N      $��0��6   $��Center=�6%   $��Center=�6@   ._�5O      �� $ HorizontalSmallDecrease��6H   8��  $��False��5P      $ 50��61   $��0,1,0,0q�6?   $��ScrollBar.LineLeftCommand��6P   5Q      ]� 5S      $ HorizontalScrollBarTrack��6   $��False��66   $��1��6R    5U      �� 5V      $ HorizontalLargeDecrease��6#   $��ScrollBar.PageLeftCommand��6D   $��False��5W   '   $ 50��69   #���  6G    5Z      n� 5[      8�� 6    5^      �� 5_      $ HorizontalLargeIncrease��6#   $ ��ScrollBar.PageRightCommand��6D   $��False��5`   '   $ 50��6:   #���  6H   5b      �� 5d      $��2��6   $��Center=�6%   $��Center=�6@   ._�5e      �� 8�� $��False��5f      $ 50��61   $��0,1,0,0q�6?   $ ��ScrollBar.LineRightCommand��6P   5g      5h       5i   
   P� 5j       �@J�IsMouseOver$
 true��6-   . �5k      �� $(	 "HorizontalScrollBarBackgroundInner��6    �@J�Opacity$	 0.5Q�6\   5l      5n      �� 5q      " ��60   .R�5r   
   � $ VerticalRoot��6   #��z��6%    5s      �� 5t      $
��Auto �6    �� 5u      $��* �6    �� 5v      $
��Auto �6    .+�5y      �� $&
  VerticalScrollBarBackgroundInner��6   $��1��6?   $��0q�6L   $ 6��6W   $
 True��6h   $	 0.3Q�6�   ���	#3F0000006�   �� 5{      $��0��6   $��Center=�6"   $��Center=�6=   ._�5|      �� $ VerticalSmallDecrease��6H   8��  $��False��5}      $ 50��61   $��0q�6?   $��ScrollBar.LineUpCommand��6J   5~      ]� 5�      $ VerticalScrollBarTrack��6   $
��true��64   $��1��6O    5�      �� 5�      $ HorizontalLargeDecrease��6#   $��ScrollBar.PageUpCommand��6D   $��False��5�   '   $ 50��69   #���  6G    5�      n� 5�      8�� $��10��6F    5�      �� 5�      $ HorizontalLargeIncrease��6#   $��ScrollBar.PageDownCommand��6D   $��False��5�   '   $ 50��69   #���  6G   5�      �� 5�      $��2��6   $��Center=�6"   $��Center=�6=   ._�5�      �� $ VerticalSmallIncrease��6H   8�� $��False��5�      $ 50��61   $��0q�6?   $��ScrollBar.LineDownCommand��6J   5�      5�       5�   
   P� 5�       �@J�IsMouseOver$
 true��6-   . �5�      �� $&	  VerticalScrollBarBackgroundInner��6    �@J�Opacity$	 0.5Q�6Z   5�      5�      �� 5�      "  ��6%   .�5�   
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5�   
    �@�OverridesDefaultStyle$
 true��62    5�   
   P� 5�       �@��Orientation$ 
Horizontal=�6-   . �5�      ��  � ��8   6-   �� 5�       � ��8  6+   5�      P� 5�       �@��Orientation$ Vertical=�6-   . �5�      ��  � ��8  6-   �� 5�       � ��8  6*   5�      5�      �� 5�      "  ��6(   .�5�   
   ��  � �� 5�      �� 5�      " ��6"   .R�5�      � $
 Grid��6   #��z��6)    5�      �� 5�      $ 
leftColumn��69   $��* �6/   69   �� 5�      $ rightColumn��6<   $
��Auto �6/   6<    5�      �� 5�      $��* �6,   �� 5�      $
��Auto �6,   .+�5�      �� $! PART_ScrollContentPresenter��61   # z��6V   $ False��5�   1   $ False��6O   #��z��6k   #��z��5�   1   #��z��6U   $��0��5�   1   $��0��6>   �� 5�      $ PART_VerticalScrollBar��6$   $ VerticalScrollBar��6D   #  z 5�   $   $! Arrow��5�   $   $��1��63   ## z" 6C   $$ 0Q�5�   $   $��0��60   #y�z% 6=   & 5�   $   �� *VerticalOffset+$' OneWay=�( �� *TemplatedParent+�� 5�      $ PART_HorizontalScrollBar��6$   $ HorizontalScrollBar��6F   $! Arrow��5�   $   $��0��63   ## z) 6C   $$ 0Q�5�   $   $* 
Horizontal=�60   $��1��6I   #y�z+ 5�   $   #  z, 5�   $   & 5�   $   �� *HorizontalOffset+$' OneWay=�( �� *TemplatedParent+5�   $   5�      5�      5�      5�      �� 5�      "  ��6   8-   6Z   �� 5�      "  ��6   8-   6`   5�      
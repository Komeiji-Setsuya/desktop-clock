   M S B A M L   `   `   `  ���� G  CDesktopClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DesktopClock.CustomDesktopClock.Custom  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBarSize  ScrollBarButton  �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� TextAlignment �� Triggers P� Property P� Value	 �� 
TargetName  ScrollBarTrackButton  ThumbTemplate
 ��Name �� CornerRadius J� SnapsToDevicePixels  HorizontalScrollBar �Name � ColumnDefinitions J� Opacity ��Name �� Interval ]�Name ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  VerticalScrollBar � RowDefinitions  DefaultScrollBar �� Triggers  DefaultScrollViewer ��Name ��Name �� CanContentScroll �� CanHorizontallyScroll �� CanVerticallyScroll ��Name4   .System.Windows.Automation.AutomationProperties    AutomationId �� ViewportHeight  �� ViewportSize! � Cursor" �� ScrollableHeight# � Maximum$ � Minimum*% �� #ComputedVerticalScrollBarVisibility& � Value' �� Mode( �� RelativeSource) �� ScrollableWidth* �� Orientation,+ �� %ComputedHorizontalScrollBarVisibility, �� ViewportWidth- �� BasedOn�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     +local!clr-namespace:DesktopClock.Custom  .sys&clr-namespace:System;assembly=mscorlib  %�  &	        &	      &	 O    &	 �    &	 �    7  7  7  &	     7  7  7  &	 x
    7  7   7  7   &	 �    '�� !    7  '�� 0    7  X�12Q��� "  ��.���  � ��
 ���� ��  � �� �	#3FFFFFFF��  � ��$ Center=���  � ��$ Center=���  � ��$
 auto����  � ��$
 auto����  � �� �� " ��.R��� $ ScrollBarButtonText��$��12(����	#3FFFFFFF$ Center=�$��Center=�$��Center=�$
��🔹��$��1q� P�  �@J�IsMouseOver$
 True��. ��� $	 ScrollBarButtonText�� � �� �	#7FFFFFFFP�  � ��$
 True��. ��� $	 ScrollBarButtonText�� � �� �	#3FFFFFFFP�  � {�$ false��. ��� $	 ScrollBarButtonText�� �@J�Opacity$	 0.5Q��� "  ��.���  � ��
 ���� ��  � �� �� " ��.R��� 
������ �� " n�.R�� .+��� $
 ScrollBarBackground��$ 4��$��2q�$
 True�����	#3FFFFFFF P�  �@J�IsMouseOver$
 True��. ��� $	 ScrollBarBackground�� � �� �	#7FFFFFFFP�  � {�$ False��. ��� $	 ScrollBarBackground�� �@J�Opacity$	 0.5Q��� " ��.R�� $ HorizontalRoot��#��z�� �� $
��Auto ��� $��* ��� $
��Auto �.+��� $(
 "HorizontalScrollBarBackgroundInner��$��1��$��0q�$
 True��$	 0.3Q�$ 6�����	#3F000000�� $��0��$��Center=�$��Center=�._��� $ HorizontalSmallDecrease��8��  $��False��$ 50��$��0,1,0,0q�$��ScrollBar.LineLeftCommand��]� $ HorizontalScrollBarTrack��$��False��$��1�� �� $ HorizontalLargeDecrease��$��ScrollBar.PageLeftCommand��$��False��$ 50��#���   n� 8��  �� $ HorizontalLargeIncrease��$ ��ScrollBar.PageRightCommand��$��False��$ 50��#���  �� $��2��$��Center=�$��Center=�._��� 8�� $��False��$ 50��$��0,1,0,0q�$ ��ScrollBar.LineRightCommand�� P�  �@J�IsMouseOver$
 true��. ��� $(	 "HorizontalScrollBarBackgroundInner�� �@J�Opacity$	 0.5Q��� " ��.R�� $ VerticalRoot��#��z�� �� $
��Auto ��� $��* ��� $
��Auto �.+��� $&
  VerticalScrollBarBackgroundInner��$��1��$��0q�$ 6��$
 True��$	 0.3Q����	#3F000000�� $��0��$��Center=�$��Center=�._��� $ VerticalSmallDecrease��8��  $��False��$ 50��$��0q�$��ScrollBar.LineUpCommand��]� $ VerticalScrollBarTrack��$
��true��$��1�� �� $ HorizontalLargeDecrease��$��ScrollBar.PageUpCommand��$��False��$ 50��#���   n� 8�� $��10�� �� $ HorizontalLargeIncrease��$��ScrollBar.PageDownCommand��$��False��$ 50��#���  �� $��2��$��Center=�$��Center=�._��� $ VerticalSmallIncrease��8�� $��False��$ 50��$��0q�$��ScrollBar.LineDownCommand�� P�  �@J�IsMouseOver$
 true��. ��� $&	  VerticalScrollBarBackgroundInner�� �@J�Opacity$	 0.5Q��� "  ��.���  �@J�SnapsToDevicePixels$
 True����  �@�OverridesDefaultStyle$
 true�� P�  �@��Orientation$ 
Horizontal=�. ���  � ��8   ��  � ��8  P�  �@��Orientation$ Vertical=�. ���  � ��8  ��  � ��8  �� "  ��.���  � �� �� " ��.R�� $
 Grid��#��z�� �� $ 
leftColumn��$��* ��� $ rightColumn��$
��Auto � �� $��* ��� $
��Auto �.+��� $! PART_ScrollContentPresenter��# z��$ False��$ False��#��z��#��z��#��z��$��0��$��0���� $ PART_VerticalScrollBar��$ VerticalScrollBar��#  z $! Arrow��$��1��## z" $$ 0Q�$��0��#y�z% & �� *VerticalOffset+$' OneWay=�( �� *TemplatedParent+�� $ PART_HorizontalScrollBar��$ HorizontalScrollBar��$! Arrow��$��0��## z) $$ 0Q�$* 
Horizontal=�$��1��#y�z+ #  z, & �� *HorizontalOffset+$' OneWay=�( �� *TemplatedParent+�� "  ��8-   �� "  ��8-   
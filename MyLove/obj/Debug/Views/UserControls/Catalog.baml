   M S B A M L   `   `   `  ����A  =MyLove, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MyLove.Views.UserControlsMyLove.Views.UserControls  5      '    !MyLove.Views.UserControls.Catalog   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:MyLove.Views.UserControls     5         Philosopher#��[  5	      .��5
      �   � RowDefinitions  5   
   �� 5      $
��0.8* �6   �� 5      $��2* �6   �� 5      $	��20* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��5      $��1��5      $��Center=�5      .+�5   
   �� $��14(�5      $��Center=�5      $
��Left=�5      $��0 0 10 0q�5      $	��300��5       ��5!      �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=��� 5#      $J��DD:\University\coursach\MyLove\MyLove\DesignElements\Icons\search.png��6   $��Right=�5$      $��Center=�5%      $��17��5&      $��17��5'      $��0 0 12 0q�5(      5)      �� 5*   
   $��2��5+      $��0��5,      $��30��5-      $	��Top=�5.      ��5/      �� *
Categories+ �� SelectedItem 50      �� *SelectedCategory+�� 52   
   $��0��53      $��2��54      $��Bottom=�55        ClearFilter#���  57      $��50��58      $��14(�59      $��10q�5:      $
��auto��5;      ��56      �� *ClearFilterCommand+5;      �� 5>   
   $
��0 10q�5?      $��2��5@      $��1��5A      $
��Auto=�5B      $��Disabled=�5C      .��5D      �� -   5         ��Name$ PictureList��5E      ��6&   �� *Eras+$ PropertyChanged=���5G      �� 5H      .R�5I      �  � 	ItemWidth$	 300��6$    � 
ItemHeight$	 350��64   $��Center=�5J       � Orientation$ 
Horizontal=�5K      5L      ��5N      �� 5O      .R�5P      �� ._�5Q      ��   Card#���  6-   5S      5T      5V      5W      5X      5Y      
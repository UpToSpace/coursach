   M S B A M L   `   `   `  ����A  =MyLove, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MyLove.Views.UserControlsMyLove.Views.UserControls  5      S.clr-namespace:MyLove.Infrastructure.Converters MyLove.Infrastructure.Converters  5      +    %MyLove.Views.UserControls.UserProfile   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:MyLove.Views.UserControls     5      c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5      9conv.clr-namespace:MyLove.Infrastructure.Converters  5         Philosopher#��[  5        � 	Resources  5      5  /MyLove.Infrastructure.Converters.AngleConverter  AngleConverter��%   &	         5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $	��11* �6   �� 5      $
��0.2* �6   .+�5   
   ]� $��1��5      $
��Auto��5      .+�5      �� $
��Left=�5       	 Hello#���  5      $��24(�5      $��Center=�5      $��0 0 5 0q�5       �� 5!      $
��Left=�5"      $��24(�5#      $��Center=�5$      ��5%      ��  �� Path$ User.Username��� 5'      $
��Left=�5(      $��24(�5)      $��Center=�5*      ��5+      �� $ 
Admin.Name��� 5-      $��Right=�5.      $��Right=�5/      $
��auto��50      $��18(�51      $	��100��52       
 LOGOUT#���  53      $��Logout��55      ��54      �� *GoToLoginPageCommand+55      57      �� 5;   
   $��3��5<      $
��Auto=�5=      .��5>      �  5?      �� 5@      $��5* �6$   �� 5A      $��6* �6$   .+�5C      � $��10q�6    5D      �� 5E      $��2* �6$   �� 5F      $��* �6$   �� 5G      $	��10* �6$    � ColumnDefinitions 5I      �� 5J      $��* �6'   �� 5K      $��* �6'   �� 5L      $��* �6'   .+�5O      �� $��0��5P      $��0��5Q      $��3��5R        
Statistics#���  5S      $��20(�5T      �� 5V      $��1��5W      $��0��5X        FavouriteCategory#���  5Y      �� 5[      $��2��5\      $��0��5]      $��Center=�5^      $��Center=�5_      $��	Underline{�5`      ��5a      �� *FavouriteCategory+�� 5c      $��1��5d      $��1��5e        ProsentOfRead#���  5f      %  Microsoft.Expression.Shapes.Arc  5h      $��2��5i      $��1��5j      $	��100��5k      $	��100��5l       �� Stretch$
 None=�5m         ArcThickness$ 10Q�5n         ArcThicknessUnit$ Pixel=�5o      ���	#FF3F3F3F   EndAngle$	 360Q�5q        5r      $��2��5s      $��1��5t      $	��100��5u      $	��100��5v      $
 None=�5w      $ 10Q�5x      $ Pixel=�5y      ���#726CCD 5{      �� *TravelValue+ �� 	Converter# [ �� 5|      $��2��5}      $��1��5~      $��Center=�5      $��Center=�5�      ��5�      �� 	 �� StringFormat$
	 {0}%��$ TravelValue��� 5�      $��1��5�      $��2��5�       
 Status#���  5�      �� 5�      $��2��5�      $��2��5�      .+�5�      �� $��10q�5�      $	��100��5�      ��5�      �� *	ImagePath+�� 5�      ��5�      �� *Status+5�      5�      �� 5�      $��1��5�      ��5�      �� *	Travels+��5�      �� 5�      .R�5�      � 
 � 	ItemWidth$	
 300��6$    � 
ItemHeight$	 250��5�   $    � Orientation$ 
Horizontal=�5�      5�      ��5�      �� 5�      .R�5�      �� ._�5�      ��  
 Travel#���  6-   5�      5�      5�      5�      5�      5�      5�      
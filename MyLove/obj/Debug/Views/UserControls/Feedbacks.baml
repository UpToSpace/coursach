   M S B A M L   `   `   `  ����A  =MyLove, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MyLove.Views.UserControlsMyLove.Views.UserControls  5      S.clr-namespace:MyLove.Infrastructure.Converters MyLove.Infrastructure.Converters  5	      )    #MyLove.Views.UserControls.Feedbacks   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:MyLove.Views.UserControls     5      ?conv.clr-namespace:MyLove.Infrastructure.Converters     5	         Philosopher#��[  5
      .��5      �   � 	Resources  5   
   6  0MyLove.Infrastructure.Converters.IsUserConverter  RoleConverter��%   &	         5      6#   5       � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $
��Auto=�5      .��5      �� ��5      �� *	Feedbacks+ �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      �  � 	ItemWidth$	 250��6$    � 
ItemHeight$	 300��5   $   $��Center=�5   $    � Orientation$ 
Horizontal=�5      5       ��5"      �� 5#      .R�5$      �� ._�5%      ��   Feedback#���  6-   5'      5(      5*      5+      � 5-   
   $��1��5.       � ColumnDefinitions 50      �� 51      $��* �6#   �� 52      $��3* �6#   �� 53      $��2* �6#   �� 54      $��* �6#   .+�56   
   �� $��1��57       �� TextWrapping$
 Wrap=�58      $
��Auto��59      $��Stretch=�5:      $
��Auto��5;      y�5<      �� *Role+ �� 	Converter# [ ��5=      �� *Description+$ PropertyChanged=��� 5?      $��2��5@        Add#���  5A      $��16(�5B      $��40��5C      $	��100��5D      $
��0 20q�5E      $��Center=�5F      $��Center=�5G      y�5H      �� *Role+# [ ��5I      �� *AddFeedbackCommand+5K      5L      5M      
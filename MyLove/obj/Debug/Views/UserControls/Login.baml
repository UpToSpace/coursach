   M S B A M L   `   `   `  ����A  =MyLove, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MyLove.Views.UserControlsMyLove.Views.UserControls  5      %    MyLove.Views.UserControls.Login   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:MyLove.Views.UserControls     5         Philosopher#��[  5	      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $
��1.5* �6   �� 5      $��* �6   �� 5      $
��1.5* �6   �� 5      $��3* �6   �� 5      $
��0.5* �6   �� 5      $��3* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��1��5      $��1��5      $��36(�5      $��Bottom=�5        	 Login#���  5!      �� 5"   
   $��2��5#      $��1��5$      $��Bottom=�5%      $
��Left=�5&        Username#���  5'      �� 5(   
   $��3��5)      $��1��5*      ��5+      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=��� 5-   
   $��4��5.      $��1��5/      $
��Left=�50      $��Bottom=�51        Password#���  52      �� 53   
   $��5��54      $��1��55      ��56      �� *
Password+$ PropertyChanged=��� 58   
   $��6��59      $��1��5:      $��OK��5;      $��UserProfile��5=      ��5<      �� *CheckDataCommand+5=      �� 5?   
   $��7��5@      $��1��5A      $��Center=�5B        Or#���  5C      �� 5D   
   $��8��5E      $��1��5F      $��24(�5G        
NewAccount#���  5H      $��Registration��5J      ��5I      �� *GoToRegistrationCommand+5J      5L      5M      
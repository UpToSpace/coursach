   M S B A M L   `   `   `  ����A  =MyLove, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MyLove.Views.UserControlsMyLove.Views.UserControls  5      #    MyLove.Views.UserControls.New   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:MyLove.Views.UserControls     5         Philosopher#��[  5	      .��5
      �   � RowDefinitions  5   
   �� 5      $
��0.2* �6   �� 5      $
��1.5* �6   �� 5      $
��0.7* �6   �� 5      $��2* �6   �� 5      $
��0.7* �6   �� 5      $��2* �6   �� 5      $��5* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��3* �6   .+�5   
   �� $��1��5      $��0��5      $��2��5        CreateNewEra#���  5      $��24(�5      �� 5   
    �� Orientation$ Vertical=�5       $��2��5!      $��5��5"      $��0��5#      $
��Auto��5$      $
��Auto��5%      $
��20 0q�5&      $��Bottom=�5'      .+�5(      �� $	��200��5*      $��0 0 0 15q�5+      ��5)      �� *PicturePath+ �� UpdateSourceTrigger$ PropertyChanged=�5+      �� 5,      $��16(�5-      $��0 0 0 10q�5.        
AddPicture#���  5/      ��50      �� *AddPictureEraCommand+51      �� 52   
   $��2��53      $��1��54      $��Bottom=�55      $
��Left=�56      #��� ��57      �� 58   
   $��1��6   $��3��59       �� 	MaxLength$ 70��5:      $��Stretch=�5;      ��5<      �� *NewEra.Name+$ PropertyChanged=��� 5>   
   $��1��5?      $��4��5@      $
��Left=�5A      $��Bottom=�5B        Description#���  5C      �� 5D   
   $��1��5E      $��5��5F      $ 70��5G      $��Stretch=�5H      ��5I      �� *NewEra.ShortDescription+$ PropertyChanged=��� 5K   
   $��1��5L      $��6��5M      $��Stretch=�5N      $��Stretch=�5O       �� TextWrapping$
 Wrap=�5P      $
��Auto��5Q      $
 1490��5R      ��5S      �� *NewEra.Description+$ PropertyChanged=��� 5U   
   $��7��5V      $��0��5W      $��30��5X      $	��200��5Y      $	��Top=�5Z      ��5[      �� *
Categories+ �� SelectedItem 5\      �� *SelectedCategory+��5]      �� 5^      .R�5_      �� ��6    �� 5`      5b      �� 5c   
   $��1��5d      $��Center=�5e      $��7��5f        Add#���  5g      ��5h      �� *AddEraCommand+��5i      �� 5j      5k      
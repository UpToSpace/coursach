   M S B A M L   `   `   `  ����A  =MyLove, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyLoveMyLove  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   5clr-namespace:MyLove.ViewModelsMyLove.ViewModels  5   	   E'clr-namespace:MyLove.Views.UserControlsMyLove.Views.UserControls  5	   	   S.clr-namespace:MyLove.Infrastructure.Converters MyLove.Infrastructure.Converters  5
   	       MyLove.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "lclr-namespace:MyLove     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   .vmclr-namespace:MyLove.ViewModels     5   	   6uc'clr-namespace:MyLove.Views.UserControls     5	   	   ?conv.clr-namespace:MyLove.Infrastructure.Converters     5
   	     � 
ResizeMode$  	CanResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$H BD:\University\coursach\MyLove\MyLove\DesignElements\Icons\logo.png��5   	      
MainWindow#���   5   	    � DataContext 5      +  %MyLove.ViewModels.MainWindowViewModel  5   
    � 	Resources 5       �� DataType%  MyLove.ViewModels.MainViewModel$   MyLove.Views.UserControls.Main(  "MyLove.ViewModels.CatalogViewModel'   !MyLove.Views.UserControls.Catalog$  MyLove.ViewModels.NewViewModel#   MyLove.Views.UserControls.New$  MyLove.ViewModels.EraViewModel#	   MyLove.Views.UserControls.Era&
   MyLove.ViewModels.LoginViewModel%   MyLove.Views.UserControls.Login-  'MyLove.ViewModels.RegistrationViewModel,   &MyLove.Views.UserControls.Registration,  &MyLove.ViewModels.UserProfileViewModel+   %MyLove.Views.UserControls.UserProfile*  $MyLove.ViewModels.FeedbacksViewModel)   #MyLove.Views.UserControls.Feedbacks)  #MyLove.ViewModels.SettingsViewModel(   "MyLove.Views.UserControls.Settings4  .MyLove.Infrastructure.Converters.RoleConverter  RoleConverter7  1MyLove.Infrastructure.Converters.IsAdminConverter  IsAdminConverter��%�  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5"      *,
 +)(�� �     5%      *, +)(�� ,    5(      *, +)(�� ^    5+      *, +)(�� �    5.      *, +)&	 �    &	 �    �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5       	  5!      �� 5"   
   " 
 6   .R�5#        5$      �� 5%   
   "  6   .R�5&        5'      �� 5(   
   "  6   .R�5)        5*      �� 5+   
   "  6   .R�5,        5-      �� 5.   
   "  6   .R�5/        50        51   
   6     52   
   6    53      .��55      �  � ColumnDefinitions 56   
   �� 57      $��* �6   �� 58      $	��50* �6   �� 59      $��* �6    � RowDefinitions 5;   
   �� 5<      $
��0.5* �6   �� 5=      $��2* �6   �� 5>      $	��30* �6   �� 5?      $��* �6   .+�5B   
   �� $��1��5C      $��1��5D      $��Center=�5E       �� Orientation$ 
Horizontal=�5F      .+�5G      	�   RadioButton#���  5H        Philosopher#��[ 5I        Main#���  5J      $
��Main��5L      	 d� 	IsChecked$
	 TrueY�5M      ��5K      �� *GoToPageCommand+5M      	� 5N      #���  5O      #��[ 5P        Catalog#���  5Q      $��Catalog��5S      ��5R      �� *GoToPageCommand+5S      	� 5T      #��[ 5V      #���  5W        New#���  5X      $	��New��5Z      y�5U      �� *Admin+
 �� 	Converter#
 [ ��5Y      �� *GoToPageCommand+5Z      	� 5[      #���  5\      #��[ 5]        Profile#���  5^      $��Login��5`      ��5_      �� *GoToPageCommand+5`      	� 5a      #���  5b      #��[ 5c       	 	Feedbacks#��� 	 5d      $��	Feedbacks��5f      ��5e      �� *GoToPageCommand+5f      	� 5g      #���  5h      #��[ 5i       
 Settings#��� 
 5j      $��Settings��5l      ��5k      �� *GoToPageCommand+5l      5m      �� 5o   
   $��1��5p      $��1��5q      $ 
Horizontal=�5r      $��Right=�5s      $��Center=�5t      .+�5u      �� $��20��5v       � Cursor$
 Hand��5w      $	��5 0q�5x      $H��BD:\University\coursach\MyLove\MyLove\DesignElements\Icons\full.png��5y       J� InputBindings 5z      d� 5{       d� Gesture$ 	LeftClicka�5}       �� Command 5|      �� *FullScreenApplicationCommand+5}      5      �� 5�      $��20��5�      $
 Hand��5�      $I��CD:\University\coursach\MyLove\MyLove\DesignElements\Icons\close.png��5�       5�      d� 5�      $ 	LeftClicka�5�       5�      �� *CloseApplicationCommand+5�      5�      5�      �� 5�   
   $��2��5�      $��1��5�      ��5�      �� *CurrentViewModel+5�      5�      
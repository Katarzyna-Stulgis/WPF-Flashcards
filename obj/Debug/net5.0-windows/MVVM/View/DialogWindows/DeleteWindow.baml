   M S B A M L   `   `   `  ����  
Flashcards5    /Flashcards.MVVM.View.DialogWindows.DeleteWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � WindowStyle$
  None=�5   	   $	��250��5   	   $	��600��6   ���#3f4152 � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      �� ���#282a36$��6q�6#   ._�5   
   �  � RowDefinitions 5      �� 5      $��30 �6    �� 5      $
��auto �6    �� 5      $��43 �6    �� 5      .+�5      �� -   5        $��Title��5      $��0��5      
�������$	��Top=�5      ���#282a365      �� 5      -   5        $��Question��5      $��1��5      
�������$��25(�5      $��Center=�5       $��Center=�5!      5"      �� 5#      -   5         ��Name$ DeletedName��5$      $��2��5#      
�������$��25(�5&      $��Center=�5'      $��Center=�5(      5)      � 5+      $��3��6    � ColumnDefinitions 5,      �� 5-      �� 5.      .+�51      �� -   5         ��Name$	 yes��54      $��0��51         YNButton#��[  52       � 	Resources 55       �� 
TargetType	 �� Property
 �� Value��%�   '��       �� 56      " ��6    .�57      �� 	 � ��$	
 TAK��68   �� 58      	 � ��$
 Right=�6D   �� 59      	 � ��$
 0,0,20,0q�67   5:      5;      5<      �� 5>      -   5        $��1��5>      #��[  5?       5A      ��%�   '��       �� 5B      " ��6    .�5C      �� 	 � ��$	
 NIE��68   �� 5D      	 � ��$

 Left=�6D   �� 5E      	 � ��$
 20,0,0,0q�67   5F      5G      5H      5I      5J      5K      5L      
   M S B A M L   `   `   `  ����N  JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel  5      E'clr-namespace:BNACTMFormGenerator.ViewsBNACTMFormGenerator.Views  5      A%clr-namespace:BNACTMFormGenerator.VMLBNACTMFormGenerator.VML  5      5    /BNACTMFormGenerator.Views.RelacionOtrosJobsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :vm+clr-namespace:BNACTMFormGenerator.ViewModel     5      6vw'clr-namespace:BNACTMFormGenerator.Views     5      5vml%clr-namespace:BNACTMFormGenerator.VML     5      .   (BNACTMFormGenerator.VML.ViewModelLocator    AutoHookedUpViewModel  . $	��386��5
      $	��500��6+    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! ..\MainWindowResources.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   .+�5+   
   �� $��0��6   $��0��6$   $��3��61   $K��EEl job debe ejecutarse si los siguentes jobs finalizaron exitosamente��6E   $
��Bold"�6�   �� 5,   
   $��0��6   $��1��6    $��Nombre Job Prod��6-   �� 5-   
   $��1��6   $��1��6    $��Nombre Job Test��6-   �� 5.   
   $��0��6   $��2��6"   $��2��6/   $	��100��6�   ��6C   �� *JobsEntrada+ �� SelectedItem 6g   �� *SelectedJobEntrada+6�   � 5/   
   $��3��6   $��2��6   $	��Top=�6,    50      �� 51      $��* �6#    53      �� 54      �� 55      .+�58      �� $��0��6   $��0��6%   $��Agregar Job��62   $	��Top=�6q   ��6H   �� *AddCommandJobEntrada+6q   �� 59      $��0��6   $��1��6%   $��
Borrar Job��62   $	��Top=�6s   ��6G   �� *DeleteCommandJobEntrada+6s   5:      �� 5;   
   $��0��6   $��4��6$   $��3��61   $�� ��6E   $
��Bold"�6N   �� 5<   
   $��0��6   $��5��6$   $��3��61   $T��NSi el job finaliza exitosamente le debe dejar condición a los siguientes jobs��6E   $
��Bold"�6�   �� 5=   
   $��0��6   $��6��6    $��Nombre Job Prod��6-   �� 5>   
   $��1��6   $��6��6    $��Nombre Job Test��6-   �� 5?   
   $��0��6   $��7��6"   $��2��6/   $	��100��6�   ��6C   �� *
JobsSalida+ 6f   �� *SelectedJobSalida+6�   � 5@   
   $��3��6   $��7��6   $	��Top=�6,    5A      �� 5B      $��* �6#    5D      �� 5E      �� 5F      .+�5I      �� $��0��6   $��0��6%   $��Agregar Job��62   ��6H   �� *AddCommandJobSalida+�� 5J      $��1��6   $��1��6%   $��
Borrar Job��62   ��6G   �� *DeleteCommandJobSalida+5K      �� 5M   
   $��0��6   $��8��6$   $��3��61   $�� ��6E   $
��Bold"�6N   �� 5N   
   $��0��6   $��9��6$   $��3��61   $J��DEl job no se podrá ejecutar en paralelo con los siguientes procesos��6E   $
��Bold"�6�   �� 5O   
   $��0��6   $��10��6    $��Nombre Job Prod��6.   �� 5P   
   $��1��6   $��10��6    $��Nombre Job Test��6.   �� 5Q   
   $��0��6   $��11��6"   $��2��60   $	��100��6�   ��6D   �� *JobsParalelos+ 6j   �� *SelectedJobParalelo+6�   � 5R   
   $��3��6   $��11��6   $	��Top=�6-    5S      �� 5T      $��* �6#    5V      �� 5W      �� 5X      .+�5[      �� $��0��6   $��0��6%   $��Agregar Job��62   ��6H   �� *AddCommandJobParalelo+�� 5\      $��1��6   $��1��6%   $��
Borrar Job��62   ��6G   �� *DeleteCommandJobParalelo+5]      �� 5_   
   $��0��6   $��12��6    $��Aclaraciones:��6.   �� 5`   
   $��1��6   $��12��5a      $��4q�5b      $��3��5c      $��2��5d      $
��Left=�5f      $	��250��5g      $��40��5h       �� TextWrapping$ WrapWithOverflow=�5i       '  #ToolTipWithErrorMessageOnErrorStyle#��[  5j      ��5e      �� *Aclaraciones+ �� Mode$ TwoWay=�	 �� ValidatesOnDataErrors	 . 
 �� NotifyOnValidationError
 . 5j      5k      5l      
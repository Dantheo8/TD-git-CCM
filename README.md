

## Déroulement de la résolution

1. J'ai voulu enregistrer et push ma modification en locales :

   ```bash
   git add .
   git commit -m "reset merge"
   ```

2. Envoyer les modifications vers le dépôt distant :

   ```bash
   git push
   ```

   Cette commande est refusée car l’historique distant a avancé indépendamment de l’historique local.

3. J'ai ensuite pull ma branche pour récupérer et fusionner les modifications distantes :

   ```bash
   git pull
   ```

   Git tente une fusion automatique, mais signale un conflit de contenu dans `index.html` :

   ```text
   CONFLICT (content): Merge conflict in index.html
   Automatic merge failed; fix conflicts and then commit the result.
   ```

4. j'ai donc ouvert `index.htm` et examiner les marqueurs ajoutés par Git :

   ```text
   <<<<<<< HEAD
   version locale
   =======
   version distante
   >>>>>>> origine/master
   ```

5. Pour résoudre le conflit, j’ai choisi la solution entrante, correspondant à la modification de mon collaborateur et ma solution, correspondant à ma modification locale.

6. Marquer le conflit comme résolu et créer le commit de fusion :

   ```bash
   git add index.htm
   git commit -m "reset merge"
   ```

7. Envoyer l’historique maintenant fusionné :

   ```bash
   git push
   ```

## image de résolution
<img width="695" height="760" alt="Image" src="https://github.com/user-attachments/assets/f855be73-8092-440f-8795-3d0e6c6a5904" />

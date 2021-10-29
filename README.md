# Challenge


Bruno Muhlmann - RM84840

Gabriel Andrade - RM83197

João Victor - RM84878

Victor Fernando - RM85058



# Script Pipeline

pipeline {
    agent any 
    tools {
        maven "apache-maven"
    }
    stages {
        stage('Responsável pela aprovação') {
            steps {
                script {
                    timeout(time: 2, unit: "HOURS") {
                    def userInput = input(
                    id: 'userInput', message: 'Deploy aprovado ?', parameters: [
                    [$class: 'TextParameterDefinition', defaultValue: 'Não', description: 'Realizar Deploy ?', name: 'Executar'] ] )
                    echo (userInput)
                    }
                }
            }
        }
        stage('Build') {
            steps {
                git 'https://github.com/Victorfer18/Challenge.git'
                bat "C:/Windows/System32/config/systemprofile/AppData/Local/Jenkins/.jenkins/workspace/CP/script.bat"
            }
            post {
                success {
                    echo 'sucesso'
                }
            }
        }
    }
}


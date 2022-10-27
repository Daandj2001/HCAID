#!/usr/bin/env python
# coding: utf-8

# In[1]:


import numpy as np
from flask import Flask, request, jsonify
import pickle
import pandas as pd
from sklearn.preprocessing import StandardScaler

# In[2]:


app = Flask(__name__)
model = pickle.load(open('model.pkl','rb'))


# In[3]:


@app.route('/api',methods=['POST'])
def predict():

    data = request.get_json(force=True)
    correctJsonData ={'BMI': data['bmi'], 'PhysHlth': data['physHlth'], 'DiffWalk': data['diffWalk'], 'Stroke': data['stroke'], 'PhysActivity': data['physActivity'], 'HeartDiseaseorAttack': data['heartDiseaseorAttack'],
     'genHlth_1.0': data['genHlth_1'], 'genHlth_2.0': data['genHlth_2'], 'genHlth_3.0': data['genHlth_3'], 'genHlth_4.0': data['genHlth_4'], 'genHlth_5.0': data['genHlth_5'], 'age_1.0': data['age_1'],
     'age_2.0': data['age_2'], 'age_3.0': data['age_3'], 'age_4.0': data['age_4'], 'age_5.0': data['age_5'], 'age_6.0': data['age_6'], 'age_7.0': data['age_7'], 'age_8.0': data['age_8'], 'age_9.0': data['age_9'],
     'age_10.0': data['age_10'], 'age_11.0': data['age_11'], 'age_12.0': data['age_12'], 'age_13.0': data['age_13'], }
    # print(correctJsonData)
    data_df = pd.DataFrame([correctJsonData])

    ss = StandardScaler()
    ss = pickle.load(open('scaler_PhysHlth.pkl','rb'))
    data_df[['PhysHlth']] = ss.transform(data_df[['PhysHlth']])
    ss = pickle.load(open('scaler_BMI.pkl','rb'))
    data_df[['BMI']] = ss.transform(data_df[['BMI']])
    print(data_df)
    prediction = model.predict(data_df)
    # output = {'DiabetesPrediction' :prediction}
    output = prediction
    # output = pd.DataFrame([output])
    return jsonify(DiabetesPrediction =output[0])


# In[ ]:


if __name__ == '__main__':
    app.run(port=5000, debug=True)


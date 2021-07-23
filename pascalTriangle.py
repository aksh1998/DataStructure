class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        ml = []
        cr = []
        pr = []
        for i in range(0, numRows):
            cr = []
            if i == 0:
                cr.append(1)
            elif i == 1:
                cr.append(1)
                cr.append(1)
            else:
                for j in range(0, len(pr)-1):
                    sum = 0
                    sum = pr[j]+pr[j+1]
                    cr.append(sum)
                cr.append(1)
                cr.insert(0, 1)
            pr = cr
            ml.append(cr)
        return ml


################################################
# public class Solution {
#     public IList < IList < int >> Generate(int numRows) {
#         var MainLi = new List < List < int >> ()
#         List < int > PrevLi = null
#         List < int > CurLi
#         for(int i=0
#             i < numRows
#             i++){
#             CurLi = new List < int > ()
#             if(i == 0){
#                 CurLi.Add(1)
#             }else if(i == 1){
#                 CurLi.Add(1)
#                 CurLi.Add(1)
#             }
#             else{
#                 int sum = 0
#                 for(int j=0
#                     j < PrevLi.Count - 1
#                     j++){
#                     sum = 0
#                     sum += PrevLi[j]+PrevLi[j+1]
#                     CurLi.Add(sum)
#                 }
#                 CurLi.Insert(0, 1)
#                 CurLi.Add(1)
#             }
#             PrevLi = new List < int > (CurLi)
#             MainLi.Add(CurLi)
#         }
#         return (IList < IList < int >> )MainLi
#     }
# }
